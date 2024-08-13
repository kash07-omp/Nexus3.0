namespace Nexus.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private ApplicationDbContext _dbContext;

        public ApplicationDbContext Init()
        {
            return _dbContext ?? (_dbContext = new ApplicationDbContext());
        }

        protected override void DisposeCore()
        {
            _dbContext?.Dispose();
        }
    }
}
