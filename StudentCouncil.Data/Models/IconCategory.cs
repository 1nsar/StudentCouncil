using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StudentCouncil.Data.Models;
[Table("IconCategories")]
public class IconCategory
{
    [Key]
    [Required]
    public int IconCategoryId { get; set;}
    [MaxLength(100)]
    [Required]
    public string CategoryName { get; set; }
}