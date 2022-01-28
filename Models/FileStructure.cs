using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentCouncil.Api.Models
{
    [Table("FileStructures")]
    public class FileStructure
    {
        [Key]
        public int FileID { get; set;}
        [MaxLength(1000)]
        public string FileName { get; set; }
        [MaxLength(10000)]
        public string PhysicalPath { get; set; } 
    }
}
