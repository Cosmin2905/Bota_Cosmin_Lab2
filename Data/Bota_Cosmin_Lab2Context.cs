using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bota_Cosmin_Lab2.Models;

namespace Bota_Cosmin_Lab2.Data
{
    public class Bota_Cosmin_Lab2Context : DbContext
    {
        public Bota_Cosmin_Lab2Context (DbContextOptions<Bota_Cosmin_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Bota_Cosmin_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Bota_Cosmin_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Bota_Cosmin_Lab2.Models.Author> Author { get; set; } = default!;
    }
}
