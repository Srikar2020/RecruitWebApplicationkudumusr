﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecruitWebApplicationkudumusr.Data;
using RecruitWebApplicationkudumusr.Models;

namespace RecruitWebApplicationkudumusr.Pages.Companies
{
    public class CreateModel : PageModel
    {
        private readonly RecruitWebApplicationkudumusr.Data.RecruitWebApplicationkudumusrContext _context;

        public CreateModel(RecruitWebApplicationkudumusr.Data.RecruitWebApplicationkudumusrContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["IndustryID"] = new SelectList(_context.Set<Industry>(), "Id", "Name");
        ViewData["JobTitleID"] = new SelectList(_context.Set<JobTitle>(), "Id", "Title");
            return Page();
        }

        [BindProperty]
        public Company Company { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Company.Add(Company);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
