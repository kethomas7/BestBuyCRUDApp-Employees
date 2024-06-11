using BestBuyCRUDApp_Employees.Models;

namespace BestBuyCRUDApp_Employees.Data
{
    public interface IEmployeeRepository
    {
        //make stubbed out methods to get, update, insert, and delete products 

        //get all employees, returns a enumerbale-collection of employees

        public IEnumerable<Employee> GetAllEmployees();
    }
}
