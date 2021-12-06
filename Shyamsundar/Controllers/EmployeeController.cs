using Microsoft.AspNetCore.Mvc;
using Shyamsundar.Models;
using System.Collections.Generic;

namespace Shyamsundar.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeService service;
        public EmployeeController()
        {
            service = new EmployeeService();
        }

        public IActionResult Index()
        {
            string message = "arjun Chawla is hero ";

            ViewData["msg"] = message;
            var customer = new List<string>()
            {"Ram","Shyam","Dhananjay" };
            //ViewBag.cus=customer;
            ViewData["cust"] = customer;
            var empList = service.GetEmployees();
            return View(empList);
        
               
    }
    }
}
