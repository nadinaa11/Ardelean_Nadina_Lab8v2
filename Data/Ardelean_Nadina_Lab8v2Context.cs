using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ardelean_Nadina_Lab8v2.Models;

namespace Ardelean_Nadina_Lab8v2.Data
{
    public class Ardelean_Nadina_Lab8v2Context : DbContext
    {
        public Ardelean_Nadina_Lab8v2Context (DbContextOptions<Ardelean_Nadina_Lab8v2Context> options)
            : base(options)
        {
        }

        public DbSet<Ardelean_Nadina_Lab8v2.Models.Book> Book { get; set; }

        public DbSet<Ardelean_Nadina_Lab8v2.Models.Publisher> Publisher { get; set; }
    }
}
