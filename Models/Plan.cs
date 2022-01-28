using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentCouncil.Api.Models
{
    [Table("Plans")]
    public class Plan
    {
        [Key]
        public int PlanID { get; set; }
        public string PlanDescription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [ForeignKey("MemberID")]
        public IEnumerable<Member> Members { get; set; }
        [ForeignKey("PriorityTypes")]
        public PriorityType Priority {get; set;}
        [ForeignKey("FileID")]
        //Document
        public IEnumerable<FileStructure> Files {get; set;}
    }
}
