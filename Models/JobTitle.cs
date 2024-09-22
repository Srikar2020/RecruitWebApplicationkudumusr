using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecruitWebApplicationkudumusr.Models
{
    public class JobTitle
    {
        [Key]
        public int Id { get; set; } 

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        public decimal MinimumSalary { get; set; }

        [Required]
        public decimal MaximumSalary { get; set; }

        public List<Candidate> Candidates { get; set; } = new List<Candidate>();
    }
}
