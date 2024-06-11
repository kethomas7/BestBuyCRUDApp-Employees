using BestBuyCRUDApp_Employees.Models;
using Dapper;
using System.Data;

namespace BestBuyCRUDApp_Employees.Data
{
    public class EmployeeRepository : IEmployeeRepository
    {

        //Fill out methods to use sql to pull data tht you want to see 


        //add a field to create the connection string to allow us to connect to a database 

        //Add a contructor to read in the connection string each time an employeeR

        private readonly IDbConnection _connection;

        public EmployeeRepository(IDbConnection connection)
        {
            _connection = connection;
        }
        public IEnumerable<Employee> GetAllEmployees()  //utilize dapper to query the bestbuy database- using the Query<T> to excute the select and return a collection/enumerable of employees
        {
            return _connection.Query<Employee>("SELECT * FROM employees");
        }
    }
}
