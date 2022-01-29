using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentCouncil.Data.Models
{
    [Table("Schools")]
    public class School
    {
        [Key]
        [Required]
        public int SchoolId { get; set; }
        [Required]
        [MaxLength(100)]
        public string SchoolName {get; set;}
        [Required]
        [MaxLength(2000)]
        public string Description {get; set;}
        [Required]
        [MaxLength(200)]
        public string UrlWebsite {get; set;}
        [Required]
        public FileStructure SchoolLogo {get; set;}
        [Required]
        public IEnumerable<Group> Classes {get; set;}
    }
}