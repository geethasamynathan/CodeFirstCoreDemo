using System.ComponentModel.DataAnnotations;

namespace CodeFirstCoreDemo.Models
{
    public class Department
    {
       // [Key]
        public int Id { get; set; }
       public string Name { get; set; }
        public string Location { get; set; }
        public string DepartmentHead { get; set; }
        public ICollection<Employee> Employees { get; set; }
       
    }
}
