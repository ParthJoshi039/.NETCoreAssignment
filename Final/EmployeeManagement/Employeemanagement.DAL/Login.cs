using Employeemanagement.DAL.Interface;
using Employeemanagement.Model;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Employeemanagement.DAL
{
    public class Login : ILogin
    {
        
        public string login(LoginModel loginModel)
        {
            if(loginModel.UserName == "Admin" && loginModel.Password == "Admin@123")
            {
                var tchandler = new JwtSecurityTokenHandler();
                var tckey = Encoding.ASCII.GetBytes("Authenticationabcdbasgbdhfhsfhjhjds h hj h ahk ja");
                var tcdescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim(ClaimTypes.Name, loginModel.UserName)
                    }),
                    Expires = DateTime.UtcNow.AddHours(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tckey), SecurityAlgorithms.HmacSha256Signature)
                };
                var tc = tchandler.CreateToken(tcdescriptor);
                return tchandler.WriteToken(tc);
                
            }
            else
            {
                return null;
            }
        }
    }
}
