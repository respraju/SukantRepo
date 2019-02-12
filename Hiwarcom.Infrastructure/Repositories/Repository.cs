using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hiwarcom.Core;
using Hiwarcom.Core.Interfaces;
using System.Data.Entity;
using Hiwarcom.Core.Models;

namespace Hiwarcom.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private bool disposed = false;
        private MainDataContext context = null;

        protected DbSet<T> DbSet
        {
            get; set;
        }

        public Repository()
        {
            context = new MainDataContext();
            DbSet = context.Set<T>();
        }

        public Repository(MainDataContext context)
        {
            this.context = context;
        }

        public void Add(T entity)
        {
            DbSet.Add(entity);
        }

        public void Delete(int id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public T GetByID(int id)
        {
            return DbSet.Find(id);
        }

        public List<T> GetAll()
        {
            return DbSet.ToList();
        }        

        public void Update(T entity)
        {
            context.Entry<T>(entity).State = EntityState.Modified;
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            if(!disposed)
            {
                context.Dispose();
                disposed = true;
            }
        }
    }
}
