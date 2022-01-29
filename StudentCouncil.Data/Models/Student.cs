using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentCouncil.Data.Models
{
    public class Student
    {
        [Key]
        [Required]
        public int StudentId { get; set; }
        [Required]
        public string FirstName {get ;set;}
        [Required]
        public string LastName {get; set;}
        [Required]
        public string UserId {get; set;}
        [Required]
        [MaxLength(40)]
        public string Email { get; set; }
        [Required]
        [MaxLength(15)]
        public string PhoneNumber { get; set; }
        public FileStructure Avatar {get; set;}
        [Required]
        public School School {get; set;}
        [Required]
        public Group Group {get; set;}
    }
}