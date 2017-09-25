using AutoMapper;
using HauLe.Model.Models;
using HauLe.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HauLe.WebApi.Infrastructure.Mappings
{
    public class AutoMapperConfiguraion
    {
        public static void Configure()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<Brand, BrandViewModel>();
                config.CreateMap<ApplicationGroup, ApplicationGroupViewModel>();
                config.CreateMap<ApplicationRole, ApplicationRoleViewModel>();
                config.CreateMap<ApplicationUser, ApplicationUserViewModel>();
            });
        }
    }
}