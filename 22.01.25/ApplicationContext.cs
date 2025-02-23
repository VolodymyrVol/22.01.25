using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace _22._01._25
{
    internal class ApplicationContext : DbContext
    {
            public DbSet<Book> Books => Set<Book>();

            public ApplicationContext() => Database.EnsureCreated();

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-S17FGQD\SQLEXPRESS;Database=firstapp;TrustServerCertificate=True;Trusted_Connection=True;");
            }
        
    }
}
