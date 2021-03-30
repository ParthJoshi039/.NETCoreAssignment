using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Employeemanagement.DAL
{
    public class EmployeeEntity
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String Department { get; set; }
        [Column (TypeName = "decimal(7,2)" )]
        public decimal Salary { get; set; }
        public Boolean IsManager { get; set; }
        public String Manager { get; set; }
        public String Phone { get; set; }
        public String EmailId { get; set; }
    }
}
