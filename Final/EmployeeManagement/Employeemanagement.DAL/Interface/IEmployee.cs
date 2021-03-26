using Employeemanagement.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Employeemanagement.DAL.Interface
{
    public interface IEmployee
    {
        //Task<List<EmployeeModel>> GetEmployees();
        //Task<EmployeeModel> GetEmployeeById(int id);
        //Task<int> AddEmployee(EmployeeModel model);
        //Task UpdateEmployee(int id, EmployeeModel);
        //Task<int> DeleteEmployee(int id);

         List<EmployeeModel> GetEmployees();
         EmployeeModel GetEmployeeById(int id);
         void AddEmployee(EmployeeModel model);
         void UpdateEmployee(int id, EmployeeModel model);
         void DeleteEmployee(int id);
         List<EmployeeModel> GetAllManagers();
    }
}
