namespace Nexus.Infrastructure.Services.Interfaces
{
    public interface IShipConstructionService
    {
        Task ProcessCompletedShipConstructionsAsync(int regionId);
    }

}
