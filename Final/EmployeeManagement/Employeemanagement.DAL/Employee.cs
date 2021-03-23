using Employeemanagement.DAL.Interface;
using Employeemanagement.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Employeemanagement.DAL
{
    public class Employee : IEmployee
    {
        EmployeeContext db;
        public Employee(EmployeeContext _db)
        {
            db = _db;
        }

        public void AddEmployee(EmployeeModel model)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public void GetEmployeeById(int id)
        {
            throw new NotImplementedException();
        }

        public  List<EmployeeModel> GetEmployees()
        {
            List<EmployeeModel> employees = new List<EmployeeModel>();
            foreach(var employee in db.Employees.ToList())
            {
                var result = new EmployeeModel()
                {
                    ID = employee.ID,
                    Name=employee.Name,
                    Department=employee.Department,
                    Salary=employee.Salary,
                    IsManager=employee.IsManager,
                    Manager=employee.Manager,
                    Phone=employee.Phone,
                    EmailId=employee.EmailId
                };
            employees.Add(result);
            }
            return employees;
        }

        public void UpdateEmployee(int id, EmployeeModel model)
        {
            throw new NotImplementedException();
        }
    }
}
