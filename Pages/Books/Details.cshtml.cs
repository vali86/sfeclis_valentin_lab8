﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using sfeclis_valentin_lab8.Data;
using sfeclis_valentin_lab8.Models;

namespace sfeclis_valentin_lab8.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly sfeclis_valentin_lab8.Data.sfeclis_valentin_lab8Context _context;

        public DetailsModel(sfeclis_valentin_lab8.Data.sfeclis_valentin_lab8Context context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
