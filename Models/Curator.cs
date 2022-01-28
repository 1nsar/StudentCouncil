using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentCouncil.Api.Models
{
    [Table("Curators")]
    public class Curator
    {
        [Key]
        public int CuratorID { get; set; }
        [ForeignKey("Members")]
        public Member Member { get; set; }
        public DateTime BecameDate {get ;set;}
    }
}