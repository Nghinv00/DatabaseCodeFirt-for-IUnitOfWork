using AutoMapper;
using HauLe.Model.Model;
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
            });
        }
    }
}