using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentCouncil.Api.Models
{
    [Table("Groups")]
    public class Group
    {
        public int GroupID { get; set; }
        public string GroupName { get; set; }
    }
}