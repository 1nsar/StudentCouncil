using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentCouncil.Api.Models
{
[Table("Departments")]
    public class Department
    {
        [Key]
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        [ForeignKey("MemberID")]
        public IEnumerable<Member> Members {get; set;}
        public string Description { get; set; }
        [ForeignKey("Curators")]
        public Curator Curator { get; set; }
        [ForeignKey("FileStructures")]
        public IEnumerable<FileStructure> Photos {get; set;}
    }
}   