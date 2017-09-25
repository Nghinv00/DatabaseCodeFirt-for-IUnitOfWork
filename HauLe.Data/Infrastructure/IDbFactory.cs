using HauLe.Model.DataModelEntity;
using HauLe.Model.Models;
using System;

namespace HauLe.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        ApplicationDbContext Init();
    }
}