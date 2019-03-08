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
        public DbSet<Song> Songs { get; set; }

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

            modelBuilder.Entity<Song>().HasData
                (
                    new Song()
                    {
                        Id = 1,
                        AlbumId = 1,
                        Title = "Strawberry Swing"                     
                    },
                    new Song()
                    {
                        Id = 2,
                        AlbumId = 1,
                        Title = "Novacane"
                    },
                    new Song()
                    {
                        Id = 3,
                        AlbumId = 1,
                        Title = "We All Try"
                    },
                    new Song()
                    {
                        Id = 4,
                        AlbumId = 1,
                        Title = "Songs 4 Women"
                    },
                    new Song()
                    {
                        Id = 5,
                        AlbumId = 1,
                        Title = "Lovecrimes"
                    },
                    new Song()
                    {
                        Id = 6,
                        AlbumId = 1,
                        Title = "There Will Be Tears"
                    },
                    new Song()
                    {
                        Id = 7,
                        AlbumId = 1,
                        Title = "Swim Good"
                    },
                    new Song()
                    {
                        Id = 8,
                        AlbumId = 1,
                        Title = "Dust"
                    },
                    new Song()
                    {
                        Id = 9,
                        AlbumId = 1,
                        Title = "American Wedding"
                    },
                    new Song()
                    {
                        Id = 10,
                        AlbumId = 1,
                        Title = "Nature Feels"
                    },
                    new Song()
                    {
                        Id = 11,
                        AlbumId = 2,
                        Title = "Start"
                    },
                    new Song()
                    {
                        Id = 12,
                        AlbumId = 2,
                        Title = "Thinkin' 'Bout You"
                    },
                    new Song()
                    {
                        Id = 13,
                        AlbumId = 2,
                        Title = "Fertilizer"
                    },
                    new Song()
                    {
                        Id = 14,
                        AlbumId = 2,
                        Title = "Sierra Leone"
                    },
                    new Song()
                    {
                        Id = 15,
                        AlbumId = 2,
                        Title = "Sweet Life"
                    },
                    new Song()
                    {
                        Id = 16,
                        AlbumId = 2,
                        Title = "Not Just Money"
                    },
                    new Song()
                    {
                        Id = 17,
                        AlbumId = 2,
                        Title = "Super Rich Kids"
                    },
                    new Song()
                    {
                        Id = 18,
                        AlbumId = 2,
                        Title = "Pilot Jones"
                    },
                    new Song()
                    {
                        Id = 19,
                        AlbumId = 2,
                        Title = "Crack Rock"
                    },
                    new Song()
                    {
                        Id = 20,
                        AlbumId = 2,
                        Title = "Pyramids"
                    },
                    new Song()
                    {
                        Id = 21,
                        AlbumId = 2,
                        Title = "Lost"
                    },
                    new Song()
                    {
                        Id = 22,
                        AlbumId = 2,
                        Title = "White"
                    },
                    new Song()
                    {
                        Id = 23,
                        AlbumId = 2,
                        Title = "Monks"
                    },
                    new Song()
                    {
                        Id = 24,
                        AlbumId = 2,
                        Title = "Bad Religion"
                    },
                    new Song()
                    {
                        Id = 25,
                        AlbumId = 2,
                        Title = "Pink Matter"
                    },
                    new Song()
                    {
                        Id = 26,
                        AlbumId = 2,
                        Title = "Forrest Gump"
                    },
                    new Song()
                    {
                        Id = 27,
                        AlbumId = 2,
                        Title = "End"
                    },
                    new Song()
                    {
                        Id = 28,
                        AlbumId = 3,
                        Title = "Nikes"
                    },
                    new Song()
                    {
                        Id = 29,
                        AlbumId = 3,
                        Title = "Ivy"
                    },
                    new Song()
                    {
                        Id = 30,
                        AlbumId = 3,
                        Title = "Pink + White"
                    },
                    new Song()
                    {
                        Id = 31,
                        AlbumId = 3,
                        Title = "Be Yourself"
                    },
                    new Song()
                    {
                        Id = 32,
                        AlbumId = 3,
                        Title = "Solo"
                    },
                    new Song()
                    {
                        Id = 33,
                        AlbumId = 3,
                        Title = "Skyline To"
                    },
                    new Song()
                    {
                        Id = 34,
                        AlbumId = 3,
                        Title = "Self Control"
                    },
                    new Song()
                    {
                        Id = 35,
                        AlbumId = 3,
                        Title = "Good Guy"
                    },
                    new Song()
                    {
                        Id = 36,
                        AlbumId = 3,
                        Title = "Nights"
                    },
                    new Song()
                    {
                        Id = 37,
                        AlbumId = 3,
                        Title = "Solo (Reprise)"
                    },
                    new Song()
                    {
                        Id = 38,
                        AlbumId = 3,
                        Title = "Pretty Sweet"
                    },
                    new Song()
                    {
                        Id = 39,
                        AlbumId = 3,
                        Title = "Facebook Story"
                    },
                    new Song()
                    {
                        Id = 40,
                        AlbumId = 3,
                        Title = "Closer To You"
                    },
                    new Song()
                    {
                        Id = 41,
                        AlbumId = 3,
                        Title = "White Ferrari"
                    },
                    new Song()
                    {
                        Id = 42,
                        AlbumId = 3,
                        Title = "Seigfried"
                    },
                    new Song()
                    {
                        Id = 43,
                        AlbumId = 3,
                        Title = "Godspeed"
                    },
                    new Song()
                    {
                        Id = 44,
                        AlbumId = 3,
                        Title = "Futara Free"
                    }
    );

            base.OnModelCreating(modelBuilder);
        }
    }
}
