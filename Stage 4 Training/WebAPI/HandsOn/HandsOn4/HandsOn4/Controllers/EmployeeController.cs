using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOn4.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOn4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private List<Employee> _employees = new List<Employee>()
        {
            new Employee() { Id = 1, Name = "Emp 1", Age = 25, Address = "KLBG"},
            new Employee() { Id = 2, Name = "Emp 2", Age = 22, Address = "BLR"},
            new Employee() { Id = 3, Name = "Emp 3", Age = 23, Address = "HYD"},
            new Employee() { Id = 4, Name = "Emp 4", Age = 28, Address = "SLPR"},
        };

        // GET: api/Employees 
        [HttpGet(Name = "GetAllEmployee")]
        public IActionResult Get()
        {
            return new ObjectResult(_employees);
        }

        // GET api/Employee/5 
        [HttpGet("{id}", Name = "GetEmployee")]
        public IActionResult Get(int id)
        {
            return new ObjectResult(_employees.FirstOrDefault(x => x.Id == id));
        }

        // POST api/Employee 
        [HttpPost(Name = "CreateEmployee")]
        public IActionResult Post([FromBody]Employee Employee)
        {
            _employees.Add(Employee);
            return CreatedAtRoute("GetEmployee", new { id = Employee.Id }, Employee);
        }

        // PUT api/Employee/5 
        [HttpPut("{id}", Name = "UpdateEmployee")]
        public IActionResult Put(int id, [FromBody]Employee Employee)
        {
            var _Employee = _employees.FirstOrDefault(x => x.Id == id);
            if (id <= 0)
            {
                return BadRequest("Invalid employee id");
            }
            else if (_Employee == null)
            {
                return BadRequest("Employee id not found");
            }
            else
            {
                _employees.FirstOrDefault(p => p.Id == id).Name = Employee.Name;
                return CreatedAtRoute("GetEmployee", new { id = Employee.Id }, Employee);
            }
        }

        // DELETE api/Employee/5 
        [HttpDelete("{id}", Name = "DeleteEmployee")]
        public IActionResult Delete(int id)
        {
            var employee = _employees.FirstOrDefault(p => p.Id == id);
            _employees.Remove(employee);
            return new NoContentResult();
        }
    }
}