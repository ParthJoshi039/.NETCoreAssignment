using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employeemanagement.DAL
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options): base (options)
        {

        }
        public DbSet<EmployeeEntity> Employees { get; set; }
    }
}
