using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentCouncil.Data.Models
{
    [Table("Groups")]
    public class Group
    {
        [Key]
        [Required]
        public int GroupId { get; set; }
        [Required]
        [MaxLength(4)]
        public char GroupChar { get; set; }
        [Required]
        public int Grade {get; set;}
        public void UpgradeGroups(){
            if(DateTime.Now == new DateTime(DateTime.Now.Year, 9, 1))
            {
                Grade++;
            }
        }
    }
}