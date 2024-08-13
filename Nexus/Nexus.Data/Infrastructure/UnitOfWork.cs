namespace Nexus.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory _dbFactory;
        private ApplicationDbContext _dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this._dbFactory = dbFactory;
        }

        public ApplicationDbContext DbContext
        {
            get { return _dbContext ?? (_dbContext = _dbFactory.Init()); }
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}
