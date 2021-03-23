using System;
using System.Collections.Generic;

#nullable disable

namespace Employeemanagement.WEBAPI.Models
{
    public partial class EmployeeInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
    }
}
