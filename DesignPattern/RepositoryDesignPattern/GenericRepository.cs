using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        void Add(T obj);
        void Update(T obj);
        void Delete(object id);
        void Save();
    }


    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private EmployeeDBContext _context = null;
        private DbSet<T> table = null;
        public GenericRepository()
        {
            _context = new EmployeeDBContext();
            table = _context.Set<T>();
        }
        public GenericRepository(EmployeeDBContext context)
        {
            _context = context;
            table = _context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }
        public T GetById(object id)
        {
            return table.Find(id);
        }
        public void Add(T obj)
        {
            table.Add(obj);
        }
        public void Update(T obj)
        {
            table.Update(obj);
        }
        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
