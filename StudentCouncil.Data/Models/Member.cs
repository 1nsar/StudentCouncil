using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentCouncil.Data.Models
{
    [Table("Members")]
    public class Member
    {
        [Key]
        [Required]
        public int MemberId { get; set; }
        [Required]
        public Student Student { get; set; }
        [Required]
        public DateTime EntryDate {get; set;}
        [Required]
        [ForeignKey("Departments")]
        public int DepartmentId {get; set;}
    }
}