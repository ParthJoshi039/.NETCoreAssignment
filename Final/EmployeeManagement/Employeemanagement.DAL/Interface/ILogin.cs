using Employeemanagement.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employeemanagement.DAL.Interface
{
    public interface ILogin
    {   
        string login(LoginModel loginModel);
    }
}
