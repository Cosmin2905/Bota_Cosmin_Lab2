﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bota_Cosmin_Lab2.Data;
using Bota_Cosmin_Lab2.Models;

namespace Bota_Cosmin_Lab2.Pages.Borrowings
{
    public class DetailsModel : PageModel
    {
        private readonly Bota_Cosmin_Lab2.Data.Bota_Cosmin_Lab2Context _context;

        public DetailsModel(Bota_Cosmin_Lab2.Data.Bota_Cosmin_Lab2Context context)
        {
            _context = context;
        }

        public Borrowing Borrowing { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Borrowing = await _context.Borrowing
             .Include(b => b.Member)
             .Include(b => b.Book)
                 .ThenInclude(book => book.Author)
             .FirstOrDefaultAsync(m => m.ID == id);

            if (Borrowing == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}