using HauLe.Model.Model;
using System;

namespace HauLe.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        HauLeEntities Init();
    }
}