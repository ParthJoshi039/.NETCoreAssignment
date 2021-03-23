using System;
using System.Collections.Generic;

#nullable disable

namespace Employeemanagement.WEBAPI.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public bool IsManager { get; set; }
        public string Manager { get; set; }
        public string Phone { get; set; }
        public string EmailId { get; set; }
    }
}
