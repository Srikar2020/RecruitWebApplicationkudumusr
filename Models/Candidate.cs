using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RecruitWebApplicationkudumusr.Models
{
    public class Candidate
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [Required]
        [Range(30000, 200000)]
        public decimal TargetSalary { get; set; }

        [Range(18, 65)]
        public int? Age { get; set; }

        
        public int? CompanyID { get; set; }
        [ForeignKey("CompanyID")]
        public Company? Company { get; set; }

        
        public int JobTitleID { get; set; }
        [ForeignKey("JobTitleID")]
        public JobTitle? JobTitle { get; set; }

        
        public int IndustryID { get; set; }
        [ForeignKey("IndustryID")]
        public Industry? Industry { get; set; }

        
        [Display(Name = "Full Name")]
        public string FullName => $"{FirstName} {LastName}";
    }
}

