using System;
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
    public class DetailsModel : PageModel
    {
        private readonly Proiect_Nohai.Data.Proiect_NohaiContext _context;

        public DetailsModel(Proiect_Nohai.Data.Proiect_NohaiContext context)
        {
            _context = context;
        }

        public Bilet Bilet { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Bilet = await _context.Bilet
                .Include(b => b.Client).FirstOrDefaultAsync(m => m.ID == id);

            if (Bilet == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
