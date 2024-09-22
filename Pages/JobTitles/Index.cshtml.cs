using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitWebApplicationkudumusr.Data;
using RecruitWebApplicationkudumusr.Models;

namespace RecruitWebApplicationkudumusr.Pages.JobTitles
{
    public class IndexModel : PageModel
    {
        private readonly RecruitWebApplicationkudumusr.Data.RecruitWebApplicationkudumusrContext _context;

        public IndexModel(RecruitWebApplicationkudumusr.Data.RecruitWebApplicationkudumusrContext context)
        {
            _context = context;
        }

        public IList<JobTitle> JobTitle { get;set; } = default!;

        public async Task OnGetAsync()
        {
            JobTitle = await _context.JobTitle.ToListAsync();
        }
    }
}
