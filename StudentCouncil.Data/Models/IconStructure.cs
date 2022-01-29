using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StudentCouncil.Data.Models;
[Table("IconStructures")]
public class IconStructure
{
    [Key]
    [Required]
    public int IconId { get; set;}
    [MaxLength(100)]
    [Required]
    public string IconName { get; set; }
    [Required]
    public IconCategory IconCategory { get; set; } 
}