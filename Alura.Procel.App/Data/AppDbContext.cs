using Alura.Procel.App.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.Procel.App.Data
{
    class AppDbContext : DbContext
    {
        public DbSet<SeloProcel> EficienciaEnergetica { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Server=(LocalDb)\\MsSqlLocalDB;Database=Alura.Blog.EFCore2.1.Enums;Trusted_Connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SeloProcel>(options => {
                options.Property(e => e.Eficiencia)
                    .HasConversion<string>(
                        e => e.ParaString(), 
                        s => s.ParaEnum()
                    );
            });
        }
    }
}
