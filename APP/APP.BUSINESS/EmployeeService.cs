using APP.DATA;
using APP.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APP.BUSINESS
{
    public class EmployeeService : IEmployeeService, IDb
    {
        public AppDbContext db { get; }
        public EmployeeService(AppDbContext dbContext)
        {
            this.db = dbContext;
        }
        public IQueryable<Employee> GetEmployees()
        {
            return this.db.Employees;
        }

        public Employee GetEmployeeById(int Id)
        {
            return this.db.Employees.Where(x => x.Id == Id).FirstOrDefault();
        }

        public bool DeleteEmployee(Employee emp)
        {
            try
            {
                this.db.Employees.Remove(emp);
                Save();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateEmployee(Employee emp)
        {
            if (this.db.Employees.Where(x => x.Id == emp.Id).Count() > 0)
            {
                this.db.Employees.Update(emp);
                Save();
                return true;
            }
            else
            {
                return false; 
            }
        }

        public Employee InsertEmployee(Employee emp)
        {

            //if (IsValidOnInsert(emp))
            ///{
            this.db.Employees.Add(emp);
            Save();
            return emp;
            //return true;
            //}
            //else
            //{
            //return false;
            //}

        }

        public void Save()
        {
            this.db.SaveChanges();
        }
    }
}
