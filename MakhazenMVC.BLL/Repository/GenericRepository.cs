using System;
using MakhazenMVC.BLL.interfaces;
using MakhazenMVC.DAL.Context;
using MakhazenMVC.DAL.Model;
using Microsoft.EntityFrameworkCore;

namespace MakhazenMVC.BLL.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;

        public GenericRepository(ApplicationDbContext context)
		{
            _context = context;
		}

        public int Create(T item)
        {
            _context.Set<T>().Add(item);
            return _context.SaveChanges();
        }

        public int Delete(T item)
        {
            _context.Set<T>().Remove(item);
            return _context.SaveChanges();
        }

        public T Get(int id)
            => _context.Set<T>().Find(id);


        public IEnumerable<T> GetAll()
        {

            return _context.Set<T>().ToList();

            }


        
        public int Update(T item)
        {
            _context.Set<T>().Update(item);
            return _context.SaveChanges();
        }
    }
}

