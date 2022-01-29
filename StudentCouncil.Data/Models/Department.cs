using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentCouncil.Data.Models
{
    [Table("Departments")]
    public class Department
    {
        [Key]
        [Required]
        public int DepartmentId { get; set; }
        [Required]
        [MaxLength(30)]
        public string DepartmentName {get; set;}
        [Required]
        public string Description {get; set;}
        [Required]
        public Curator Curator {get; set;}
        [Required]
        public IEnumerable<Member> DepartmentMembers {get; set;}
        [Required]
        public IEnumerable<Plan> DepartmentPlans {get; set;}
        [Required]
        public IEnumerable<Report> DepartmentReports {get; set;}
    }
}