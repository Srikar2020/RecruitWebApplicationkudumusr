using System.ComponentModel.DataAnnotations;

namespace RecruitWebApplicationkudumusr.Models
{
    public class Industry
    {
     
        [Key]
        public int Id { get; set; }  

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

    
        public List<Company> Companies { get; set; } = new List<Company>();
        public List<Candidate> Candidates { get; set; } = new List<Candidate>();
    }
}

