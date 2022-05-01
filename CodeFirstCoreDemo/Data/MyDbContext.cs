
using Microsoft.EntityFrameworkCore;
using CodeFirstCoreDemo.Models;

namespace CodeFirstCoreDemo.Data
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Department>().HasData(

                new Department() { Id = 1, Name = "IT", Location = "Dalllas", DepartmentHead = "Karthik" },
                 new Department() { Id = 2, Name = "HR", Location = "Alabama", DepartmentHead = "Riya" },
                  new Department() { Id = 3, Name = "Admin", Location = "Masachuset", DepartmentHead = "Tina" });
        }
    }
}
