using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Employeemanagement.Model
{
    public class EmployeeModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String Department { get; set; }
        [Required]
        public decimal Salary { get; set; }
        [Required]
        public Boolean IsManager { get; set; }
        [Required]
        public String Manager { get; set; }
        [Required]
        public String Phone { get; set; }
        [Required]
        public String EmailId { get; set; }

    }
}
