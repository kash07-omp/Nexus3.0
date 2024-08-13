namespace Nexus.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        ApplicationDbContext Init();
    }
}
