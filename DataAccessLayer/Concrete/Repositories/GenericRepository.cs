﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T:class
    {
        Context c = new Context();
        DbSet<T> _object;

        public GenericRepository()
        {
            _object = c.Set<T>();
        }

        public void Delete(T p)
        {
            var entityToDelete = c.Entry(p);
            entityToDelete.State = EntityState.Deleted;
            //_object.Remove(p);
            c.SaveChanges();
        }

        public void Insert(T p)
        {
            var entityToAdd = c.Entry(p);
            entityToAdd.State = EntityState.Added;
            c.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T p)
        {
            var entityToUpdate = c.Entry(p);
            entityToUpdate.State = EntityState.Modified;
            c.SaveChanges();
        }
    }
}
