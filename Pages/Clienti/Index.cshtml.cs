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
    public class IndexModel1 : PageModel
    {
        private readonly Proiect_Nohai.Data.Proiect_NohaiContext _context;

        public IndexModel1(Proiect_Nohai.Data.Proiect_NohaiContext context)
        {
            _context = context;
        }

        public IList<Client> Client { get;set; }

        public async Task OnGetAsync()
        {
            Client = await _context.Client
                .Include(c => c.Reducere).ToListAsync();
        }
    }
}
