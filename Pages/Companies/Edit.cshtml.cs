using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RecruitWebApplicationkudumusr.Data;
using RecruitWebApplicationkudumusr.Models;

namespace RecruitWebApplicationkudumusr.Pages.Companies
{
    public class EditModel : PageModel
    {
        private readonly RecruitWebApplicationkudumusr.Data.RecruitWebApplicationkudumusrContext _context;

        public EditModel(RecruitWebApplicationkudumusr.Data.RecruitWebApplicationkudumusrContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Company Company { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company =  await _context.Company.FirstOrDefaultAsync(m => m.Id == id);
            if (company == null)
            {
                return NotFound();
            }
            Company = company;
           ViewData["IndustryID"] = new SelectList(_context.Set<Industry>(), "Id", "Name");
           ViewData["JobTitleID"] = new SelectList(_context.Set<JobTitle>(), "Id", "Title");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Company).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompanyExists(Company.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CompanyExists(int id)
        {
            return _context.Company.Any(e => e.Id == id);
        }
    }
}
