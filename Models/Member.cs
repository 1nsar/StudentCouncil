using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentCouncil.Api.Models
{
    [Table("Members")]
    public class Member
    {
        [Key]
        public int MemberID { get; set; }
        [ForeignKey("StudentID")]
        public Student Student {get; set;}
        public DateTime JoinDate { get; set; } 
        public string JoinReason { get; set; }
    }
}