namespace Nexus.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private NexusEntities _dbContext;

        public NexusEntities Init()
        {
            return _dbContext ?? (_dbContext = new NexusEntities());
        }

        protected override void DisposeCore()
        {
            _dbContext?.Dispose();
        }
    }
}
