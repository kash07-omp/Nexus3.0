using Nexus.Domain.Entities;

namespace Nexus.Infrastructure.Services.Interfaces
{
    public interface IFleetMovementService
    {
        /// <summary>
        /// Calcula el camino más corto desde la posición actual de una flota hasta el destino utilizando el algoritmo A*.
        /// </summary>
        /// <param name="fleet">La flota a mover.</param>
        /// <param name="destination">El destino objetivo (coordenadas).</param>
        /// <returns>Lista de coordenadas que representan el camino calculado.</returns>
        Task<List<(int x, int y)>> CalculatePath(Fleet fleet, (int x, int y) destination);
        Task SaveFleetPath(Fleet fleet, List<(int x, int y)> path, TimeSpan travelTimePerStep);
    }
}
