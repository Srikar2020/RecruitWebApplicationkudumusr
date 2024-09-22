using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitWebApplicationkudumusr.Models;

namespace RecruitWebApplicationkudumusr.Data
{
    public class RecruitWebApplicationkudumusrContext : DbContext
    {
        public RecruitWebApplicationkudumusrContext (DbContextOptions<RecruitWebApplicationkudumusrContext> options)
            : base(options)
        {
        }

        public DbSet<RecruitWebApplicationkudumusr.Models.Candidate> Candidate { get; set; } = default!;
        public DbSet<RecruitWebApplicationkudumusr.Models.Company> Company { get; set; } = default!;
        public DbSet<RecruitWebApplicationkudumusr.Models.Industry> Industry { get; set; } = default!;
        public DbSet<RecruitWebApplicationkudumusr.Models.JobTitle> JobTitle { get; set; } = default!;
    }
}
