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
            var employee = new EmployeeEntity()
            {
                Name=model.Name,
                Department=model.Department,
                Salary=model.Salary,
                IsManager=model.IsManager,
                Manager=model.Manager,
                Phone=model.Phone,
                EmailId=model.EmailId
            };
           db.Employees.Add(employee);
           db.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            var employee = db.Employees.FirstOrDefault(x => x.ID == id);
            if(employee != null)
            {
                db.Employees.Remove(employee);
                db.SaveChanges();
            }
        }

        public EmployeeModel GetEmployeeById(int id)
        {
           
                var employee = db.Employees.FirstOrDefault(x => x.ID == id);
                var result = new EmployeeModel()
                {
                    Name = employee.Name,
                    Department = employee.Name,
                    Salary = employee.Salary,
                    IsManager = employee.IsManager,
                    Manager = employee.Manager,
                    Phone = employee.Phone,
                    EmailId = employee.EmailId
                };
                return result;
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
            db.SaveChanges();
            }
            return employees;
        }

        public void UpdateEmployee(int id, EmployeeModel model)
        {
            var employee = db.Employees.FirstOrDefault(x => x.ID == id);
            if (employee != null)
            {
                employee.Name = model.Name;
                employee.Department = model.Department;
                employee.Salary = model.Salary;
                employee.IsManager = model.IsManager;
                employee.Manager = model.Manager;
                employee.Phone = model.Phone;
                employee.EmailId = model.EmailId;
            }
            db.SaveChanges();
        }
        public List<EmployeeModel> GetAllManagers()
        {
            List<EmployeeModel> employee = new List<EmployeeModel>();
            foreach(var empname in db.Employees.Where(x=>x.IsManager==true).Select(x=>x.Name).ToList())
            {
                var response = new EmployeeModel()
                {
                    Name = empname,
                };
                employee.Add(response);
            }
            return employee;
        }
    }
}
