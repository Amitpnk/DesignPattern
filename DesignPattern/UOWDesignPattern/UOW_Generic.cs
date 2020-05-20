using RepositoryDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UOWDesignPattern
{
    public interface IUnitOfWork_Generic<T> where T : class
    {
        GenericRepository<T> employeeRepository { get; }
        Task<int> CompleteAsync();
        int Complete();
    }


    public class UOW_Generic<T> : IUnitOfWork_Generic<T>  where T : class
    {
        private readonly EmployeeDBContext dbContext;
        public UOW_Generic(EmployeeDBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        private GenericRepository<T> _employeeRepository;
        public GenericRepository<T> employeeRepository
        {
            get
            {
                if (this._employeeRepository == null)
                {
                    this._employeeRepository = new GenericRepository<T>(dbContext);
                }
                return this._employeeRepository;
            }
        }

        public async Task<int> CompleteAsync()
        {
            return await dbContext.SaveChangesAsync();
        }
        public int Complete()
        {
            return dbContext.SaveChanges();
        }
        public void Dispose() => dbContext.Dispose();

    }
}
