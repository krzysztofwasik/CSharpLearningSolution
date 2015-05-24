using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using StatsWebService.DAL.Entities;

namespace StatsWebService.DAL.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T: EntityBase
    {
        private StatsDbContext context;

        protected Repository(StatsDbContext context)
        {
            this.context = context;
        }

        public virtual List<T> Get()
        {
            return this.context.Set<T>().ToList();
        }

        public virtual T Get(int id)
        {
            return this.context.Set<T>().Find(id);
        }

        public virtual T Update(T obj)
        {
            this.context.Entry(obj).State = EntityState.Modified;
            this.context.SaveChanges();

            return obj;
        }

        public virtual T Insert(T obj)
        {
            this.context.Set<T>().Add(obj);
            this.context.SaveChanges();

            return obj;
        }

        public virtual int Delete(T obj)
        {
            this.context.Set<T>().Remove(obj);
            
            return this.context.SaveChanges();
        }
    }
}