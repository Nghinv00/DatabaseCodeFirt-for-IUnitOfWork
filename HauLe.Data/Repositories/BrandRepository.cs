using HauLe.Data.Infrastructure;
using HauLe.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HauLe.Data.Repositories
{
    public interface IBrandRepository: IRepository<Brand>
    {

    }
    public class BrandRepository : RepositoryBase<Brand>, IBrandRepository
    {
        public BrandRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
