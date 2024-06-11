using Microsoft.AspNetCore.Mvc;
using BestBuyCRUDApp_Employees.Data;

namespace BestBuyCRUDApp_Employees.Controllers
{
    public class EmployeeController : Controller
    {

        //each method in the controller correseponds to a view we have to create

        private readonly IEmployeeRepository repo; //makes a new iemployee called repo//thought you couldnt reinstance interfaces

        public EmployeeController(IEmployeeRepository repo)//dont understand why
        {
            this.repo = repo;
        }

        public IActionResult Index()//Will return a view page of the same name Index with the appropriate Model data (IEnumerable)
        {
            var employees = repo.GetAllEmployees(); //uses the new interface to get all employees
            return View(employees);
        }
    }
}
