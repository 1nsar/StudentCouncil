using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StudentCouncil.Data.Models;

[Table("Students")]
public class Student
{
    [Key]
    public int StudentID { get; set; }
    public Group Class { get; set; }
    [ForeignKey("AspNetUsers")]
    public string UserId {get; set;}
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    [ForeignKey("FileStructures")]
    //Avatarka
    public FileStructure Avatar {get; set;}
}