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
                        AlbumId = 1,
                        Title = "Nostalgia, Ultra",
                        Artist = "Frank Ocean"
                    },
                    new Album()
                    {
                        AlbumId = 2,
                        Title = "Channel Orange",
                        Artist = "Frank Ocean"
                    },
                    new Album()
                    {
                        AlbumId = 3,
                        Title = "Blonde",
                        Artist = "Frank Ocean"
                    }
                );

            modelBuilder.Entity<Song>().HasData
                (
                    new Song()
                    {
                        SongId = 1,
                        AlbumId = 1,
                        Title = "Strawberry Swing"                     
                    },
                    new Song()
                    {
                        SongId = 2,
                        AlbumId = 1,
                        Title = "Novacane"
                    },
                    new Song()
                    {
                        SongId = 3,
                        AlbumId = 1,
                        Title = "We All Try"
                    },
                    new Song()
                    {
                        SongId = 4,
                        AlbumId = 1,
                        Title = "Songs 4 Women"
                    },
                    new Song()
                    {
                        SongId = 5,
                        AlbumId = 1,
                        Title = "Lovecrimes"
                    },
                    new Song()
                    {
                        SongId = 6,
                        AlbumId = 1,
                        Title = "There Will Be Tears"
                    },
                    new Song()
                    {
                        SongId = 7,
                        AlbumId = 1,
                        Title = "Swim Good"
                    },
                    new Song()
                    {
                        SongId = 8,
                        AlbumId = 1,
                        Title = "Dust"
                    },
                    new Song()
                    {
                        SongId = 9,
                        AlbumId = 1,
                        Title = "American Wedding"
                    },
                    new Song()
                    {
                        SongId = 10,
                        AlbumId = 1,
                        Title = "Nature Feels"
                    },
                    new Song()
                    {
                        SongId = 11,
                        AlbumId = 2,
                        Title = "Start"
                    },
                    new Song()
                    {
                        SongId = 12,
                        AlbumId = 2,
                        Title = "Thinkin' 'Bout You"
                    },
                    new Song()
                    {
                        SongId = 13,
                        AlbumId = 2,
                        Title = "Fertilizer"
                    },
                    new Song()
                    {
                        SongId = 14,
                        AlbumId = 2,
                        Title = "Sierra Leone"
                    },
                    new Song()
                    {
                        SongId = 15,
                        AlbumId = 2,
                        Title = "Sweet Life"
                    },
                    new Song()
                    {
                        SongId = 16,
                        AlbumId = 2,
                        Title = "Not Just Money"
                    },
                    new Song()
                    {
                        SongId = 17,
                        AlbumId = 2,
                        Title = "Super Rich Kids"
                    },
                    new Song()
                    {
                        SongId = 18,
                        AlbumId = 2,
                        Title = "Pilot Jones"
                    },
                    new Song()
                    {
                        SongId = 19,
                        AlbumId = 2,
                        Title = "Crack Rock"
                    },
                    new Song()
                    {
                        SongId = 20,
                        AlbumId = 2,
                        Title = "Pyramids"
                    },
                    new Song()
                    {
                        SongId = 21,
                        AlbumId = 2,
                        Title = "Lost"
                    },
                    new Song()
                    {
                        SongId = 22,
                        AlbumId = 2,
                        Title = "White"
                    },
                    new Song()
                    {
                        SongId = 23,
                        AlbumId = 2,
                        Title = "Monks"
                    },
                    new Song()
                    {
                        SongId = 24,
                        AlbumId = 2,
                        Title = "Bad Religion"
                    },
                    new Song()
                    {
                        SongId = 25,
                        AlbumId = 2,
                        Title = "Pink Matter"
                    },
                    new Song()
                    {
                        SongId = 26,
                        AlbumId = 2,
                        Title = "Forrest Gump"
                    },
                    new Song()
                    {
                        SongId = 27,
                        AlbumId = 2,
                        Title = "End"
                    },
                    new Song()
                    {
                        SongId = 28,
                        AlbumId = 3,
                        Title = "Nikes"
                    },
                    new Song()
                    {
                        SongId = 29,
                        AlbumId = 3,
                        Title = "Ivy"
                    },
                    new Song()
                    {
                        SongId = 30,
                        AlbumId = 3,
                        Title = "Pink + White"
                    },
                    new Song()
                    {
                        SongId = 31,
                        AlbumId = 3,
                        Title = "Be Yourself"
                    },
                    new Song()
                    {
                        SongId = 32,
                        AlbumId = 3,
                        Title = "Solo"
                    },
                    new Song()
                    {
                        SongId = 33,
                        AlbumId = 3,
                        Title = "Skyline To"
                    },
                    new Song()
                    {
                        SongId = 34,
                        AlbumId = 3,
                        Title = "Self Control"
                    },
                    new Song()
                    {
                        SongId = 35,
                        AlbumId = 3,
                        Title = "Good Guy"
                    },
                    new Song()
                    {
                        SongId = 36,
                        AlbumId = 3,
                        Title = "Nights"
                    },
                    new Song()
                    {
                        SongId = 37,
                        AlbumId = 3,
                        Title = "Solo (Reprise)"
                    },
                    new Song()
                    {
                        SongId = 38,
                        AlbumId = 3,
                        Title = "Pretty Sweet"
                    },
                    new Song()
                    {
                        SongId = 39,
                        AlbumId = 3,
                        Title = "Facebook Story"
                    },
                    new Song()
                    {
                        SongId = 40,
                        AlbumId = 3,
                        Title = "Closer To You"
                    },
                    new Song()
                    {
                        SongId = 41,
                        AlbumId = 3,
                        Title = "White Ferrari"
                    },
                    new Song()
                    {
                        SongId = 42,
                        AlbumId = 3,
                        Title = "Seigfried"
                    },
                    new Song()
                    {
                        SongId = 43,
                        AlbumId = 3,
                        Title = "Godspeed"
                    },
                    new Song()
                    {
                        SongId = 44,
                        AlbumId = 3,
                        Title = "Futara Free"
                    }
    );

            base.OnModelCreating(modelBuilder);
        }
    }
}
