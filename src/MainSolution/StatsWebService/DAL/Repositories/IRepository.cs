using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StatsWebService.DAL.Entities;

namespace StatsWebService.DAL.Repositories
{
    public interface IRepository<T> where T : EntityBase
    {
        List<T> Get();
        T Get(int id);
        T Update(T obj);
        T Insert(T obj);
        int Delete(T obj);
    }
}