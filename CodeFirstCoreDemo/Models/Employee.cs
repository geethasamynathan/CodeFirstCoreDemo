using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstCoreDemo.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
        [ForeignKey("Department")]
        public int Deptid { get; set; }
      public Department? Department { get; set; }
        
    }
}
