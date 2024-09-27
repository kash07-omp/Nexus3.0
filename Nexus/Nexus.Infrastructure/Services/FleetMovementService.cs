using Nexus.Domain.Entities;
using Nexus.Infrastructure.Data;
using Nexus.Infrastructure.Services.Interfaces;
using Microsoft.EntityFrameworkCore;  // Asegúrate de usar EF Core

public class FleetMovementService : IFleetMovementService
{
    private readonly ApplicationDbContext _context;

    public FleetMovementService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<FleetMovementPath>> CalculatePath(Fleet fleet, (int x, int y) destination)
    {
        var start = (fleet.CoordinateX, fleet.CoordinateY);
        var gridSizeX = fleet.SolarSystem.GridSizeX;
        var gridSizeY = fleet.SolarSystem.GridSizeY;

        // Obtener todas las flotas en el sistema solar
        var fleetsInSolarSystem = await _context.Fleets
            .Where(f => f.SolarSystemId == fleet.SolarSystemId)
            .ToListAsync();

        // HashSet con posiciones ocupadas por flotas enemigas
        var occupiedPositions = new HashSet<(int x, int y)>(
            fleetsInSolarSystem
                .Where(f => f.UserId != fleet.UserId)
                .Select(f => (f.CoordinateX, f.CoordinateY))
        );

        // Añadir posición de la estrella
        occupiedPositions.Add((gridSizeX / 2 + 1, gridSizeY / 2 + 1));

        // Inicializamos las listas para el algoritmo A*
        var openList = new List<Node>();
        var closedList = new HashSet<Node>();

        var startNode = new Node(start.CoordinateX, start.CoordinateY, null, 0, ManhattanDistance(start, destination));
        openList.Add(startNode);

        // Obtener la velocidad mínima de la flota
        var slowestSpeed = fleet.FleetShips.Min(fs => fs.Ship.Speed);

        // Almacenar el resultado como FleetMovementPath
        var pathList = new List<FleetMovementPath>();
        var currentTime = DateTime.UtcNow;

        // Búsqueda A* con lista abierta y cerrada
        while (openList.Any())
        {
            var currentNode = openList.OrderBy(n => n.F).First();

            // Si llegamos al destino, construimos el camino
            if (currentNode.X == destination.x && currentNode.Y == destination.y)
            {
                var path = BuildPath(currentNode);

                for (int i = 0; i < path.Count - 1; i++)
                {
                    var from = path[i];
                    var to = path[i + 1];

                    // Calcular tiempo de viaje según si es movimiento horizontal/vertical o diagonal
                    var movementCost = GetMovementCost(new Node(from.x, from.y), new Node(to.x, to.y));
                    var travelTime = TimeSpan.FromSeconds((slowestSpeed * movementCost)/2);

                    pathList.Add(new FleetMovementPath
                    {
                        FleetId = fleet.Id,
                        FromX = from.x,
                        FromY = from.y,
                        ToX = to.x,
                        ToY = to.y,
                        DepartureTime = currentTime,
                        ArrivalTime = currentTime.Add(travelTime)
                    });

                    // Actualizar la hora para la siguiente celda
                    currentTime = currentTime.Add(travelTime);
                }

                return pathList;
            }

            openList.Remove(currentNode);
            closedList.Add(currentNode);

            // Iterar sobre los vecinos de la celda actual
            foreach (var neighbor in GetNeighbors(currentNode, gridSizeX, gridSizeY))
            {
                if (occupiedPositions.Contains((neighbor.X, neighbor.Y)) || closedList.Any(n => n.X == neighbor.X && n.Y == neighbor.Y))
                    continue;

                var gCost = currentNode.G + GetMovementCost(currentNode, neighbor);
                var existingNode = openList.FirstOrDefault(n => n.X == neighbor.X && n.Y == neighbor.Y);

                if (existingNode == null)
                {
                    var hCost = ManhattanDistance((neighbor.X, neighbor.Y), destination);
                    var neighborNode = new Node(neighbor.X, neighbor.Y, currentNode, gCost, hCost);
                    openList.Add(neighborNode);
                }
                else if (gCost < existingNode.G)
                {
                    existingNode.Parent = currentNode;
                    existingNode.G = gCost;
                }
            }
        }

        return null; // No path found
    }

    public async Task UpdateFleetPositions(List<Fleet> fleets)
    {
        var currentTime = DateTime.UtcNow;

        foreach (var fleet in fleets)
        {
            // Obtener todos los FleetMovementPaths ordenados por ArrivalTime
            var movementPaths = await _context.FleetMovementPaths
                .Where(fmp => fmp.FleetId == fleet.Id)
                .OrderBy(fmp => fmp.ArrivalTime)
                .ToListAsync();

            if (!movementPaths.Any())
            {
                continue; // No hay movimientos pendientes, saltamos esta flota
            }

            // Buscar el último movimiento completado y actualizar la posición de la flota
            var lastCompletedPath = movementPaths.LastOrDefault(fmp => fmp.ArrivalTime <= currentTime);

            if (lastCompletedPath != null)
            {
                // Actualizar las coordenadas de la flota a la posición de destino del último movimiento completado
                fleet.CoordinateX = lastCompletedPath.ToX;
                fleet.CoordinateY = lastCompletedPath.ToY;
            }

            // Eliminar todos los FleetMovementPaths que ya han sido completados (ArrivalTime <= currentTime)
            var completedPaths = movementPaths.Where(fmp => fmp.ArrivalTime <= currentTime).ToList();
            _context.FleetMovementPaths.RemoveRange(completedPaths);

            // Si aún quedan movimientos por completar, la flota está en el último punto del último movimiento no completado
            var nextPath = movementPaths.FirstOrDefault(fmp => fmp.ArrivalTime > currentTime);
            if (nextPath != null)
            {
                fleet.CoordinateX = nextPath.FromX;
                fleet.CoordinateY = nextPath.FromY;
            }

            // Actualizar la flota
            _context.Fleets.Update(fleet);
        }

        // Guardar todos los cambios en la base de datos
        await _context.SaveChangesAsync();
    }



    private List<Node> GetNeighbors(Node node, int gridSizeX, int gridSizeY)
    {
        var neighbors = new List<Node>();

        var directions = new (int dx, int dy)[]
        {
            (0, 1), (1, 0), (0, -1), (-1, 0), // Horizontal y vertical
            (1, 1), (-1, 1), (1, -1), (-1, -1) // Diagonales
        };

        foreach (var dir in directions)
        {
            var newX = node.X + dir.dx;
            var newY = node.Y + dir.dy;
            if (newX >= 1 && newX <= gridSizeX && newY >= 1 && newY <= gridSizeY)
            {
                neighbors.Add(new Node(newX, newY));
            }
        }

        return neighbors;
    }

    private int GetMovementCost(Node from, Node to)
    {
        // Movimiento en diagonal cuesta 14, en línea recta cuesta 10
        return (from.X != to.X && from.Y != to.Y) ? 7 : 5;
    }

    private int ManhattanDistance((int x, int y) from, (int x, int y) to)
    {
        return Math.Abs(from.x - to.x) + Math.Abs(from.y - to.y);
    }

    private List<(int x, int y)> BuildPath(Node node)
    {
        var path = new List<(int x, int y)>();
        while (node != null)
        {
            path.Add((node.X, node.Y));
            node = node.Parent;
        }
        path.Reverse();
        return path;
    }
}

public class Node
{
    public int X { get; }
    public int Y { get; }
    public Node Parent { get; set; }
    public int G { get; set; } // Movement cost from start
    public int H { get; } // Heuristic cost to destination
    public int F => G + H; // Total cost

    public Node(int x, int y, Node parent = null, int g = 0, int h = 0)
    {
        X = x;
        Y = y;
        Parent = parent;
        G = g;
        H = h;
    }
}
