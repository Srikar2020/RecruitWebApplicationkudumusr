using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecruitWebApplicationkudumusr.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }  

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Required]
        [StringLength(150)]
        public string PositionName { get; set; }

        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [Required]
        [StringLength(200)]
        public string Location { get; set; }

        [Required]
        public decimal MinimumSalary { get; set; }

        [Required]
        public decimal MaximumSalary { get; set; }

        public int IndustryID { get; set; }
        [ForeignKey("IndustryID")]
        public Industry? Industry { get; set; }

        public int JobTitleID { get; set; }
        [ForeignKey("JobTitleID")]
        public JobTitle? JobTitle { get; set; }

        public virtual List<Candidate> Candidates { get; set; } = new List<Candidate>();
    }
}

