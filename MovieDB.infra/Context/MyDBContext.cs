using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieDB.domain.Entities;

namespace MovieDB.infra.Context
{
    public class MyDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public MyDBContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                string connectionString = "server=localhost; " +
                "port=3306; database=moviedb; user=root; " +
                "password=1234";
                dbContextOptionsBuilder.UseMySql(connectionString,
                ServerVersion.AutoDetect(connectionString));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Movie>(entity =>
            {
                entity.HasKey(x => x.ID);
                entity.Property(x => x.Name).HasMaxLength(50).IsRequired();
                entity.Property(x => x.Description).HasMaxLength(255).IsRequired();
                entity.Property(x => x.ReleaseYear).IsRequired();
                entity.Property(x => x.Genre).HasMaxLength(50).IsRequired();
                //entity.Property(x => x.Genre).HasConversion(
                //    x => string.Join(',' x),
                //    x => x.Split(',', StringSplitOptions.RemoveEmptyEntries);
            });
        }   


    }
}
