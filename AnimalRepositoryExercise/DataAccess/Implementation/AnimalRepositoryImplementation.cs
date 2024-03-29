﻿using DataAccess.Abstract;
using DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Implementation
{
    public class AnimalRepositoryImplementation<T> : IRepository<T> where T : class
    {
        private Db_Context _context;
        private DbSet<T> table;


        public AnimalRepositoryImplementation()
        {
            this._context = new Db_Context();
            table = _context.Set<T>();
        }
        public AnimalRepositoryImplementation(Db_Context context)
        {
            this._context = context;
            table = _context.Set<T>();
        }

        public void Create(T entity)
        {
            table.Add(entity);
        }

        public void Delete(object id)
        {
            T e = table.Find(id);
            table.Remove(e);
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(object id)
        {
            return table.Find(id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            table.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
