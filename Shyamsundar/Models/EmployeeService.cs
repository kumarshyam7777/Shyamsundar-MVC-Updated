using System.Collections.Generic;
using System.Linq;

namespace Shyamsundar.Models
{
    public class EmployeeService
    {
        private List<Employee> Employees;
        public EmployeeService()
        {
            Employees = new List<Employee>();
            {
                new Employee() { Id = 1, Name = "arjun", Email = "gsomesh42@gmail.com" };
                new Employee() { Id = 2, Name = "piyush", Email = "gsomesh42@gmail.com" };
                new Employee() { Id = 3, Name = "piyush", Email = "piyushchawla917@gmail.com" };
                new Employee() { Id = 4, Name = "shyam", Email = "shyam@gmail.com" };
            };
        }
        public List<Employee> GetEmployees()
        {
            return Employees.ToList();
        }

    }
}
