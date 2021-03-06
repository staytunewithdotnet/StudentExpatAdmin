﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using studentexpat.com.Models;

namespace studentexpat.com.Pages.admin.languages
{
    public class DetailsModel : PageModel
    {
        private readonly studentexpat.com.Models.DB_A3A1FE_stexpContext _context;

        public DetailsModel(studentexpat.com.Models.DB_A3A1FE_stexpContext context)
        {
            _context = context;
        }

        public Language Language { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Language = await _context.Language.SingleOrDefaultAsync(m => m.Id == id);

            if (Language == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
