using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HauLe.Model.Model;
using HauLe.Data.Infrastructure;
using HauLe.Data.Repositories;

namespace HauLe.Service
{
    public interface IBrandService
    {
        IEnumerable<Brand> GetAll();
    }
    public class BrandService : IBrandService
    {
        public IUnitOfWork _unitOfWork;
        public IBrandRepository _brandRepository;
        public BrandService(IBrandRepository brandRepository, IUnitOfWork unitOfWork)
        {
            this._brandRepository = brandRepository;
            this._unitOfWork = unitOfWork;
        }
        public IEnumerable<Brand> GetAll()
        {
            return this._brandRepository.GetAll();
        }
    }
}
