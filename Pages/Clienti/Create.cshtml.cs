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
    public class CreateModel1 : PageModel
    {
        private readonly Proiect_Nohai.Data.Proiect_NohaiContext _context;

        public CreateModel1(Proiect_Nohai.Data.Proiect_NohaiContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ReducereID"] = new SelectList(_context.Reducere, "ID", "TipReducere");
            return Page();
        }

        [BindProperty]
        public Client Client { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Client.Add(Client);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
