﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using studentexpat.com.Models;

namespace studentexpat.com.Pages.admin.categories
{
    public class DetailsModel : PageModel
    {
        private readonly studentexpat.com.Models.DB_A3A1FE_stexpContext _context;

        public DetailsModel(studentexpat.com.Models.DB_A3A1FE_stexpContext context)
        {
            _context = context;
        }

        public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category = await _context.Category
                .Include(c => c.Language).SingleOrDefaultAsync(m => m.Id == id);

            if (Category == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
