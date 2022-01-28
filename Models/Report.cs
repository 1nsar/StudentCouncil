using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentCouncil.Api.Models
{
    [Table("Reports")]
    public class Report
    {
        [Key]
        public int ReportID { get; set; }
        public string ReportName { get; set; }
        public DateTime ReportDate { get; set; }
        [ForeignKey("Curators")]
        public Curator Curator { get; set; }
        public string Description { get; set; }
        [ForeignKey("FileStructures")]
        //Document
        public FileStructure Document {get; set;}
    }
}