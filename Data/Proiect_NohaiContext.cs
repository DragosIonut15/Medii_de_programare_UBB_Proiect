using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect_Nohai.Models;

namespace Proiect_Nohai.Data
{
    public class Proiect_NohaiContext : DbContext
    {
        public Proiect_NohaiContext (DbContextOptions<Proiect_NohaiContext> options)
            : base(options)
        {
        }

        public DbSet<Proiect_Nohai.Models.Bilet> Bilet { get; set; }

        public DbSet<Proiect_Nohai.Models.Client> Client { get; set; }

        public DbSet<Proiect_Nohai.Models.Reducere> Reducere { get; set; }
    }
}
