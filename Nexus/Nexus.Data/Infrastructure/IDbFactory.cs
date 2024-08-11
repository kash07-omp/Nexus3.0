namespace Nexus.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        NexusEntities Init();
    }
}
