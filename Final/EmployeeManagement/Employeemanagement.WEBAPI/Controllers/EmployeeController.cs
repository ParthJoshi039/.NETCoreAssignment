using Employeemanagement.DAL.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Employeemanagement.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IEmployee employee;
        public EmployeeController(IEmployee iemployee)
        {
            employee = iemployee;
        }
        [HttpGet]
        [Route("Employee/GetEmployees")]
        public IActionResult GetEmployees()
        {
            try
            {
                var result = employee.GetEmployees();
                return Ok(result);
            }
            catch (Exception e)
            {
                return Ok();
            }
        }
    }
}
