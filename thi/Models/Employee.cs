using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace thi.Models
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        [Required]
        public int EmployeeId { get; set; }
        [Required]
        public string EmployeeName { get; set; }
        [Required]
        public DateTime EmployeeDOB { get; set; }

        [Required]
        public string EmployeeDepartment { get; set; }
        
        public virtual ICollection<ProjectEmployee> ProjectEmployees { get; set; }

    }
}
