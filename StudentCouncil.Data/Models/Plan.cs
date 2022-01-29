using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentCouncil.Data.Models
{
    [Table("Plans")]
    public class Plan
    {
        [Key]
        [Required]
        public int PlanId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Description {get; set;}
        [Required]
        public Member Author {get; set;}
        [Required]
        public IEnumerable<FileStructure> File {get; set;}
        [Required]
        public DateTime StartDate {get; set;}
        [Required]
        public DateTime Deadline {get; set;}
        public Department Department {get; set;}
    }
}