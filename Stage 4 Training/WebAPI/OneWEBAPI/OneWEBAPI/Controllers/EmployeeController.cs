using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OneWEBAPI.Models;

namespace OneWEBAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> _employees = new List<Employee>()
        {
            new Employee() {Id = 1, Name = "Kiran", Age = 21},
            new Employee() {Id = 2, Name = "Rakesh", Age = 23},
            new Employee() {Id = 3, Name = "Mahesh", Age = 24},
            new Employee() {Id = 4, Name = "Atul", Age = 20}
        };
        private readonly ILogger<EmployeeController> _logger;

        //Injection of logger in the Constructor
        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }

        //To get list of employee
        [HttpGet]
        public IEnumerable<Employee> Get()  //Method name can be user defined also as this does not make any problem for end user
        {
            return _employees;
        }

        //To insert into the list
        //In postman select post for the method type>body>raw>JSON>Paste data>Send
        [HttpPost]
        public void Post(Employee employee)
        {
            _employees.Add(employee);
        }

        [HttpGet]
        [Route("GetEmployee/{id}")]
        public Employee FindEmployee(/*[FromHeader]*/ int id)
        {
            return _employees.Find(x => x.Id == id);
        }

        [HttpPut]
        [Route("UpdateEmployee/{id}")]
        public Employee Put(int id, Employee employee)
        {
            var result = _employees.FindIndex(x => x.Id == id);
            _employees[result] = employee;

            return _employees[result];
        }
    }
}