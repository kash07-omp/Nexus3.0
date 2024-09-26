using Nexus.Domain.Entities;
using Nexus.Infrastructure.Data;
using Nexus.Infrastructure.Services.Interfaces;
using System.Data.Entity;

public class FleetMovementService : IFleetMovementService
{
    private readonly ApplicationDbContext _context;

    public FleetMovementService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<(int x, int y)>> CalculatePath(Fleet fleet, (int x, int y) destination)
    {
        var start = (fleet.CoordinateX, fleet.CoordinateY);
        var gridSizeX = fleet.SolarSystem.GridSizeX;
        var gridSizeY = fleet.SolarSystem.GridSizeY;

        // Obtener todas las flotas en el sistema solar, incluyendo las enemigas
        var fleetsInSolarSystem = await _context.Fleets
            .Where(f => f.SolarSystemId == fleet.SolarSystemId)
            .ToListAsync();

        // Crear un HashSet con las posiciones ocupadas por flotas enemigas para rápido acceso
        var occupiedPositions = new HashSet<(int x, int y)>(
            fleetsInSolarSystem
                .Where(f => f.UserId != fleet.UserId)
                .Select(f => (f.CoordinateX, f.CoordinateY))
        );

        // Añadir la posición de la estrella al HashSet de posiciones ocupadas
        occupiedPositions.Add((gridSizeX / 2 + 1, gridSizeY / 2 + 1));

        // Inicializamos las listas para el algoritmo A*
        var openList = new List<Node>();
        var closedList = new HashSet<Node>();

        var startNode = new Node(start.CoordinateX, start.CoordinateY, null, 0, ManhattanDistance(start, destination));
        openList.Add(startNode);

        // Búsqueda A* con lista abierta y cerrada
        while (openList.Any())
        {
            var currentNode = openList.OrderBy(n => n.F).First();

            // Si llegamos al destino, construimos el camino
            if (currentNode.X == destination.x && currentNode.Y == destination.y)
            {
                return BuildPath(currentNode);
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

    public async Task SaveFleetPath(Fleet fleet, List<(int x, int y)> path, TimeSpan travelTimePerStep)
    {
        var currentTime = DateTime.UtcNow;
        var pathList = new List<FleetMovementPath>();

        for (int i = 0; i < path.Count - 1; i++)
        {
            pathList.Add(new FleetMovementPath
            {
                FleetId = fleet.Id,
                FromX = path[i].x,
                FromY = path[i].y,
                ToX = path[i + 1].x,
                ToY = path[i + 1].y,
                DepartureTime = currentTime,
                ArrivalTime = currentTime.Add(travelTimePerStep)
            });
            currentTime = currentTime.Add(travelTimePerStep); // update current time for the next step
        }

        _context.FleetMovementPaths.AddRange(pathList);
        await _context.SaveChangesAsync();
    }


    private List<Node> GetNeighbors(Node node, int gridSizeX, int gridSizeY)
    {
        var neighbors = new List<Node>();

        // Definimos las direcciones para vecinos (vertical, horizontal, diagonal)
        var directions = new (int dx, int dy)[]
        {
            (0, 1), (1, 0), (0, -1), (-1, 0), // Vertical y horizontal
            (1, 1), (-1, 1), (1, -1), (-1, -1) // Diagonal
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
        return (from.X != to.X && from.Y != to.Y) ? 14 : 10;
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
