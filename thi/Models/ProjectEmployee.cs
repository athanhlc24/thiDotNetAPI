using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace thi.Models
{
    [Table("ProjectEmployees")]
    public class ProjectEmployee
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeId { get; set; }

        public int ProjectId { get; set; }
        [Required]
        public string Tasks { get; set; }
        public virtual Employee Employees { get; set; }
        public virtual Project Projects { get; set; }
    }
}
