using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentCouncil.Data.Models
{
    [Table("Reports")]
    public class Report
    {
        [Key]
        [Required]
        public int ReportId { get; set; }
        [Required]
        [MaxLength(100)]
        public string ReportName {get; set;}
        [Required]
        public string Description {get; set;}
        [Required]
        public Member Author {get; set;}
        [Required]
        public IEnumerable<FileStructure> File {get; set;}
    }
}