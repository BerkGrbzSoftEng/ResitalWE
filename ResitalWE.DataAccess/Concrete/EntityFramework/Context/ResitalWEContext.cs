﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ResitalWE.Entities.ComplexType;
using ResitalWE.Entities.Concrete;
using ResitalWE.Entities.Report;

namespace ResitalWE.DataAccess.Concrete.EntityFramework.Context
{
    public class ResitalWEContext : DbContext
    {
        private static List<string> dbs = new List<string>();
        public string DatabaseName { get; set; }
        public DbSet<Report.BankaKrediDetay> BankaKrediDetay { get; set; }
        public DbSet<CKart> CKart { get; set; }
        public DbSet<SKart> SKart { get; set; }
        public DbSet<CHare> CHare { get; set; }
        public DbSet<AbgCariHareketOzet> AbgCariHareketOzet { get; set; }
        public DbSet<AbgSatisRapor> ABGSatisRapor { get; set; }
        public DbSet<ABGSatisYillik> AbgSatisYillik { get; set; }
        public DbSet<ABGAlisYillik> AbgAlisYillik { get; set; }
        public DbSet<SFaturaD> SFaturaD { get; set; }
        public DbSet<CariTahsilatD> CariTahsilatD { get; set; }
        public DbSet<CariOdemeD> CariOdemeD { get; set; }
        public DbSet<vw_ABGBankaAylikRapor> vw_ABGBankaAylikRapor { get; set; }
        public DbSet<BankaAyOzet> BankaAyOzet { get; set; }
        public DbSet<vw_ABGCariAylikRapor> vw_ABGCariAylikRapor { get; set; }
        public DbSet<CariAyOzet> CariAyOzet { get; set; }
        public DbSet<StDepo> StDepo { get; set; }
        public DbSet<SHare> SHare { get; set; }
        public DbSet<SKartMM> SKartMM { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Report.BankaKrediDetay>(entity => { entity.HasNoKey(); });
            modelBuilder.Entity<BankaAyOzet>(entity => { entity.HasNoKey(); });

            modelBuilder.Entity<vw_ABGBankaAylikRapor>(entity =>
            {
                entity.HasNoKey();
                entity.ToView("vw_ABGBankaAylikRapor");
            });
            modelBuilder.Entity<CariAyOzet>(entity => { entity.HasNoKey(); });
            modelBuilder.Entity<vw_ABGCariAylikRapor>(entity =>
            {
                entity.HasNoKey();
                entity.ToView("vw_ABGCariAylikRapor");
            });

        }

        public void Doldur(string dbName)
        {
            dbs.Add(dbName);
            string server = string.Format(@"{0}", Environment.MachineName);
            OnConfiguring(optionsBuilder: new DbContextOptionsBuilder().UseSqlServer($"Server={server};Database={dbs.Last()};Trusted_Connection=true;Connect Timeout=30"));
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string server = string.Format(@"{0}", Environment.MachineName);
            string dbName = dbs.Last();
            optionsBuilder.UseSqlServer($"Server={server};Database={dbName};Trusted_Connection=true;Connect Timeout=30");


        }



    }
}
