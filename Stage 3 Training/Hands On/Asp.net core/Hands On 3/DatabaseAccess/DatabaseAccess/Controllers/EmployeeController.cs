using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DatabaseAccess.Controllers
{
    public class EmployeeController : Controller
    {
        private CompanyContext _context;
        private ILogger<Startup> _logger;

        public EmployeeController(CompanyContext context, ILogger<Startup> logger)
        {
            _context = context;
            _logger = logger;
        }
        public async Task<IActionResult> IndexAsync()
        {
            var employeeList = await _context.Employees.Include(x => x.Department).ToListAsync();
            //_logger.LogInformation($"The total list value is {employeeList.Count}");

            if (employeeList.Count > 0)
            {
                _logger.LogInformation(MyCustomLogData.AllGood, "The code is working well");
                return View("IndexAsync", employeeList);
            }
            else
            {
                _logger.LogInformation(MyCustomLogData.ItemCountZero, "No values found");
                return View("IndexAsync", employeeList);
            }
            
        }
    }
}