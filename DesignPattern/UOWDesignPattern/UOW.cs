using RepositoryDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UOWDesignPattern
{
    public interface IUnitOfWork
    {
        IEmployeeRepository employeeRepository { get; }
        Task<int> CompleteAsync();
        int Complete();
    }


    public class UnitOfWork : IUnitOfWork
    {
        private readonly EmployeeDBContext dbContext;
        public UnitOfWork(EmployeeDBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        private IEmployeeRepository _employeeRepository;
        public IEmployeeRepository employeeRepository
        {
            get
            {
                if (this._employeeRepository == null)
                {
                    this._employeeRepository = new EmployeeRepository(dbContext);
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
