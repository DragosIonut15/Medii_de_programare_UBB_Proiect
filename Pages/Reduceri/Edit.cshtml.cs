using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proiect_Nohai.Data;
using Proiect_Nohai.Models;

namespace Proiect_Nohai
{
    public class EditModel2 : PageModel
    {
        private readonly Proiect_Nohai.Data.Proiect_NohaiContext _context;

        public EditModel2(Proiect_Nohai.Data.Proiect_NohaiContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Reducere).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReducereExists(Reducere.ID))
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

        private bool ReducereExists(int id)
        {
            return _context.Reducere.Any(e => e.ID == id);
        }
    }
}
