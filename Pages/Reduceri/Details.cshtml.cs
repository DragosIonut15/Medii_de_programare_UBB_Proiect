﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_Nohai.Data;
using Proiect_Nohai.Models;

namespace Proiect_Nohai
{
    public class DetailsModel2 : PageModel
    {
        private readonly Proiect_Nohai.Data.Proiect_NohaiContext _context;

        public DetailsModel2(Proiect_Nohai.Data.Proiect_NohaiContext context)
        {
            _context = context;
        }

        public Reducere Reducere { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Reducere = await _context.Reducere.FirstOrDefaultAsync(m => m.ID == id);

            if (Reducere == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
