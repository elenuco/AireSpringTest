using Microsoft.EntityFrameworkCore;
using System;

namespace AireSpringTest.Models
{
    public class EmpleadosDbContext : DbContext
    {
        public EmpleadosDbContext(DbContextOptions<EmpleadosDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
