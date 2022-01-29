using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentCouncil.Data.Models
{
    [Table("PriorityTypes")]
    public class PriorityType
    {
        [Key]
        [Required]
        public int PriorityTypeId { get; set; }
        [Required]
        [MaxLength(15)]
        public string PriorityTypeName {get; set;}
    }
}