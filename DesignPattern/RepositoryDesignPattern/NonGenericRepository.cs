using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern
{

    public interface IEmployeeRepository 
    {
        IEnumerable<Employee> GetAll();
        Employee GetById(int EmployeeID);
        void Add(Employee employee);
        void Update(Employee employee);
        void Delete(int EmployeeID);
        void Save();
    }

    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDBContext _context;
        public EmployeeRepository()
        {
            _context = new EmployeeDBContext();
        }
        public EmployeeRepository(EmployeeDBContext context)
        {
            _context = context;
        }
        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }
        public Employee GetById(int EmployeeID)
        {
            return _context.Employees.Find(EmployeeID);
        }
        public void Add(Employee employee)
        {
            _context.Employees.Add(employee);
        }
        public void Update(Employee employee)
        {
            _context.Entry(employee).State = EntityState.Modified;
        }
        public void Delete(int EmployeeID)
        {
            Employee employee = _context.Employees.Find(EmployeeID);
            _context.Employees.Remove(employee);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
       
    
    }
}
