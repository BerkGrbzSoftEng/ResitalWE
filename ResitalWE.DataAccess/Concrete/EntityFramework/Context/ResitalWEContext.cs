using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ResitalWE.Entities.Concrete;
using ResitalWE.Entities.Report;

namespace ResitalWE.DataAccess.Concrete.EntityFramework.Context
{
    public class ResitalWEContext:DbContext
    {
     
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-AOR6FI3;Database=OZEL2020;Trusted_Connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Report.BankaKrediDetay>(entity => { entity.HasNoKey(); });
        }
        public DbSet<Report.BankaKrediDetay> BankaKrediDetay { get; set; }
        public DbSet<CKart> CKart { get; set; }
        public DbSet<SKart> SKart { get; set; }
        public DbSet<CHare> Chare { get; set; }
    }
}
