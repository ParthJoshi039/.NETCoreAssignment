using Employeemanagement.DAL.Interface;
using Employeemanagement.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Employeemanagement.WEBAPI.Controllers
{
    [Authorize]
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
        [Route("GetEmployees")]
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
        [HttpGet]
        [Route("GetManagers")]
        public IActionResult GetAllManagers()
        {
            try
            {
                var result = employee.GetAllManagers();
                return Ok(result);
            }
            catch (Exception e)
            {
                return Ok();
            }
        }

        [HttpPost]
        [Route("AddEmployee")]
        public IActionResult AddEmployee(EmployeeModel model)
        {
            employee.AddEmployee(model);
            return Ok("Employee Added Successfully");
        }

        [HttpGet]
        [Route("GetEmployeeById")]
        public IActionResult GetEmployeeById(int id)
        {
            var result = employee.GetEmployeeById(id);
            return Ok(result);
        }

        [HttpDelete]
        [Route("DeleteEmployee")]
        public IActionResult DeleteEmployee(int id)
        {
            employee.DeleteEmployee(id);
            return Ok("Employee Deleted Successfully");
        }

        [HttpPut]
        [Route("UpdateEmployee")]
        public IActionResult UpdateEmployee(int id, EmployeeModel model)
        {
            employee.UpdateEmployee(id, model);
            return Ok("Employee Updated Successfully");
        }
    }
}
