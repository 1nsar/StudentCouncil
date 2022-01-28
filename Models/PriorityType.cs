using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentCouncil.Api.Models
{
    [Table("PriorityTypes")]
    public class PriorityType
    {
        [Key]
        public int TypeID { get; set; }
        public string TypeName {get ;set; }
    }
}