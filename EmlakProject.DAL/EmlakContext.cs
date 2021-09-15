using EmlakProject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmlakProject.DAL
{
    public class EmlakContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-TCN3U77;Initial Catalog=EmlakDB;User=sa;Password=sa;");
        }

        public DbSet<EmlakBilgisi> EmlakBilgisi { get; set; }
        public DbSet<Emlakci> Emlakci { get; set; }
        public DbSet<Musteri> Musteri { get; set; }


    }
}
