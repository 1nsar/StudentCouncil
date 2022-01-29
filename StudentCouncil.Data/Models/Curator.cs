using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentCouncil.Data.Models
{
    [Table("Curators")]
    public class Curator
    {
        [Key]
        [Required]
        public int CuratorId { get; set; }
        [Required]
        [MaxLength(30)]
        public Department Department {get; set;}
        [Required]
        public IEnumerable<Plan> Plans {get; set;}
    }
}