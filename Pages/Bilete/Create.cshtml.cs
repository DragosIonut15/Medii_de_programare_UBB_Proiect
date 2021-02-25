using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proiect_Nohai.Data;
using Proiect_Nohai.Models;

namespace Proiect_Nohai
{
    public class CreateModel : PageModel
    {
        private readonly Proiect_Nohai.Data.Proiect_NohaiContext _context;

        public CreateModel(Proiect_Nohai.Data.Proiect_NohaiContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ClientID"] = new SelectList(_context.Client, "ID", "NumeClient");
            return Page();
        }

        [BindProperty]
        public Bilet Bilet { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Bilet.Add(Bilet);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
