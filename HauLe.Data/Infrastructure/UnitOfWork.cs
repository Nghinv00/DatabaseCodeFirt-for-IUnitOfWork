using HauLe.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HauLe.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private HauLeEntities dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public HauLeEntities DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }

        //Customer by HauLe
        public void Refresh()
        {
            dbContext.Dispose();
            dbContext = dbFactory.Init();
        }


        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}
