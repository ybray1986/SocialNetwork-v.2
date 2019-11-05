﻿using SocialNetwork.WEB.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SocialNetwork.WEB.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private DbContext db;
        private DbSet<T> table;
        public Repository()
        {
            db = new SocialNetworkContext();
            table = db.Set<T>();
        }
        public Repository(DbContext model)
        {
            this.db = model;
            table = db.Set<T>();
        }
        public void Add(T model)
        {
            table.Add(model);
        }

        public void Delete(int id)
        {
            T result = table.Find(id);
            table.Remove(result);
        }

        public void Update(T model)
        {
            db.Entry(model).State = EntityState.Modified;
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public T Get(int id)
        {
            return table.Find(id);
        }
    }
}