
using HauLe.Model.Model;

namespace HauLe.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private HauLeEntities dbContext;

        public HauLeEntities Init()
        {
            return dbContext ?? (dbContext = new HauLeEntities());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}