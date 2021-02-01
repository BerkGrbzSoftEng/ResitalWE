using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ResitalWE.Entities.Concrete;
using ResitalWE.Entities.Report;

namespace ResitalWE.DataAccess.Concrete.EntityFramework.Context
{
    public class ResitalWEContext : DbContext
    {
        public DbSet<Report.BankaKrediDetay> BankaKrediDetay { get; set; }
        public DbSet<CKart> CKart { get; set; }
        public DbSet<SKart> SKart { get; set; }
        public DbSet<CHare> CHare { get; set; }
        public DbSet<AbgCariHareketOzet> AbgCariHareketOzet { get; set; }
        public DbSet<AbgSatisRapor> ABGSatisRapor { get; set; }
        public DbSet<ABGSatisYillik> AbgSatisYillik { get; set; }
        public DbSet<ABGAlisYillik> AbgAlisYillik { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-AOR6FI3;Database=DECOM20;Trusted_Connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Report.BankaKrediDetay>(entity => { entity.HasNoKey(); });


        }

    }
}
