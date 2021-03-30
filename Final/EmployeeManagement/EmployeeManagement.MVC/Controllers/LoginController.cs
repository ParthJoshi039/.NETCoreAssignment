using Employeemanagement.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.MVC.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult login()
        {
            try
            {
                return View();
            }
            catch(Exception ex)
            {
                return RedirectToAction("Error", "Login");
            }
        }
        [HttpPost]
        public async Task<IActionResult> login(LoginModel loginModel)
        {
            try
            {
                using (HttpClient hc = new HttpClient())
                {
                    StringContent stringContent = new StringContent(JsonConvert.SerializeObject(loginModel), Encoding.UTF8, "application/json");
                    using (var response = await hc.PostAsync("https://localhost:44302/api/Login/Login",stringContent))
                    {
                        if(response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            var ApiResponse = await response.Content.ReadAsStringAsync();
                            HttpContext.Session.SetString("Token", ApiResponse);
                            HttpContext.Session.SetString("UserName", loginModel.UserName);
                            return RedirectToAction("Index", "Employee");
                        }
                        else
                        {
                            ViewBag.Message = "Invalid Credential";
                            return View();
                        }
                    }

                }
            }
            catch(Exception ex)
            {
                return RedirectToAction("Error", "Login");
            }
        }
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.SetString("Token", "");
            HttpContext.Session.SetString("UserName", "");
            return RedirectToAction("Login", "Login");
        }



    }
}
