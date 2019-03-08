using AlbumCollection.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection
{
    public class AlbumContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=anjrAlbumCollection;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().HasData
                (
                    new Album()
                    {
                        Id = 1,
                        Title = "Nostalgia, Ultra",
                        Artist = "Frank Ocean"
                    },
                    new Album()
                    {
                        Id = 2,
                        Title = "Channel Orange",
                        Artist = "Frank Ocean"
                    },
                    new Album()
                    {
                        Id = 3,
                        Title = "Blonde",
                        Artist = "Frank Ocean"
                    }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
