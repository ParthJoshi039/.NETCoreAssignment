using Employeemanagement.DAL.Interface;
using Employeemanagement.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employeemanagement.WEBAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        ILogger ilogger;
        ILogin ilogin;
        public LoginController(ILogin login, ILogger<LoginController> logger)
        {
            ilogin = login;
            ilogger = logger;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("Login")]
        public IActionResult Login([FromBody] LoginModel loginModel)
        {
            try
            {
                string tc = ilogin.login(loginModel);
                if (tc != null)
                {
                    return Ok(tc);
                }
                else
                {
                    return Unauthorized();
                }
            }
            catch (Exception ex)
            {
                ilogger.LogError(ex.Message);
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
