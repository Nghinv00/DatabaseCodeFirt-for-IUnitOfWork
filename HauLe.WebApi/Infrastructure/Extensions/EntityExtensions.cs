using HauLe.Model.Model;
using HauLe.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HauLe.WebApi.Infrastructure.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdateBrand(this Brand brand, BrandViewModel brandVM)
        {
            brand.Id = brandVM.Id;
            brand.Name = brandVM.Name;
            brand.Logo = brandVM.Logo;
            brand.Ord = brandVM.Ord;
            brand.Lang = brandVM.Lang;
            brand.NameEn = brandVM.NameEn;
        }
    }
}