using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StudentCouncil.Data.Models;
[Table("FileStructures")]
public class FileStructure
{
    [Key]
        public int FileID { get; set;}
        [MaxLength(1000)]
        public string FileName { get; set; }
        [MaxLength(8000)]
        public string PhysicalPath { get; set; } 
}