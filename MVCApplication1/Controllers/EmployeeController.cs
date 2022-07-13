using Microsoft.AspNetCore.Mvc;
using MVCApplication1.Models;
namespace MVCApplication1.Controllers
{
      

    [Route("[controller]")]
    public class EmployeeController : Controller

    {

        List<Employee> emp = new List<Employee>
            {
                  new Employee() { EmployeeId = 1, EmployeeName = "Mr.A", EmployeeCity = "Chennai" } ,
                new Employee() { EmployeeId = 2, EmployeeName = "Mr.B",  EmployeeCity = "Bangalore" } ,
                new Employee() { EmployeeId = 3, EmployeeName = "Mr.C",  EmployeeCity = "Kerala" } ,
                new Employee() { EmployeeId = 4, EmployeeName = "Mr.D" , EmployeeCity = "Chennai" }
            };



        [Route("List")]
        public IActionResult Index()
        {

            return View(emp);
        }

        public IActionResult Save(Employee input)
        { 
            emp.Add(input);
            return View(emp);
        }
       
       
    }
}
