using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Terec_Ioan_Lab8.Models;

namespace Terec_Ioan_Lab8.Data
{
    public class Terec_Ioan_Lab8Context : DbContext
    {
        public Terec_Ioan_Lab8Context (DbContextOptions<Terec_Ioan_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Terec_Ioan_Lab8.Models.Book> Book { get; set; }

        public DbSet<Terec_Ioan_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Terec_Ioan_Lab8.Models.Category> Category { get; set; }
    }
}
