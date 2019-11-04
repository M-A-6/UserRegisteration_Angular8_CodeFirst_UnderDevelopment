using APP.MODEL;
using System.Linq;

namespace APP.BUSINESS
{
    public interface IEmployeeService
    {
        IQueryable<Employee> GetEmployees();
        Employee GetEmployeeById(int Id);

        bool DeleteEmployee(Employee emp);
        bool UpdateEmployee(Employee emp);
        Employee InsertEmployee(Employee emp);
        
    }
}
