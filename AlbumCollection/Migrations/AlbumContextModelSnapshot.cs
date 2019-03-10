﻿// <auto-generated />
using AlbumCollection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AlbumCollection.Migrations
{
    [DbContext(typeof(AlbumContext))]
    partial class AlbumContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AlbumCollection.Models.Album", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Artist");

                    b.Property<string>("Title");

                    b.HasKey("AlbumId");

                    b.ToTable("Albums");

                    b.HasData(
                        new { AlbumId = 1, Artist = "Frank Ocean", Title = "Nostalgia, Ultra" },
                        new { AlbumId = 2, Artist = "Frank Ocean", Title = "Channel Orange" },
                        new { AlbumId = 3, Artist = "Frank Ocean", Title = "Blonde" }
                    );
                });

            modelBuilder.Entity("AlbumCollection.Models.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumId");

                    b.Property<string>("Title");

                    b.HasKey("SongId");

                    b.HasIndex("AlbumId");

                    b.ToTable("Songs");

                    b.HasData(
                        new { SongId = 1, AlbumId = 1, Title = "Strawberry Swing" },
                        new { SongId = 2, AlbumId = 1, Title = "Novacane" },
                        new { SongId = 3, AlbumId = 1, Title = "We All Try" },
                        new { SongId = 4, AlbumId = 1, Title = "Songs 4 Women" },
                        new { SongId = 5, AlbumId = 1, Title = "Lovecrimes" },
                        new { SongId = 6, AlbumId = 1, Title = "There Will Be Tears" },
                        new { SongId = 7, AlbumId = 1, Title = "Swim Good" },
                        new { SongId = 8, AlbumId = 1, Title = "Dust" },
                        new { SongId = 9, AlbumId = 1, Title = "American Wedding" },
                        new { SongId = 10, AlbumId = 1, Title = "Nature Feels" },
                        new { SongId = 11, AlbumId = 2, Title = "Start" },
                        new { SongId = 12, AlbumId = 2, Title = "Thinkin' 'Bout You" },
                        new { SongId = 13, AlbumId = 2, Title = "Fertilizer" },
                        new { SongId = 14, AlbumId = 2, Title = "Sierra Leone" },
                        new { SongId = 15, AlbumId = 2, Title = "Sweet Life" },
                        new { SongId = 16, AlbumId = 2, Title = "Not Just Money" },
                        new { SongId = 17, AlbumId = 2, Title = "Super Rich Kids" },
                        new { SongId = 18, AlbumId = 2, Title = "Pilot Jones" },
                        new { SongId = 19, AlbumId = 2, Title = "Crack Rock" },
                        new { SongId = 20, AlbumId = 2, Title = "Pyramids" },
                        new { SongId = 21, AlbumId = 2, Title = "Lost" },
                        new { SongId = 22, AlbumId = 2, Title = "White" },
                        new { SongId = 23, AlbumId = 2, Title = "Monks" },
                        new { SongId = 24, AlbumId = 2, Title = "Bad Religion" },
                        new { SongId = 25, AlbumId = 2, Title = "Pink Matter" },
                        new { SongId = 26, AlbumId = 2, Title = "Forrest Gump" },
                        new { SongId = 27, AlbumId = 2, Title = "End" },
                        new { SongId = 28, AlbumId = 3, Title = "Nikes" },
                        new { SongId = 29, AlbumId = 3, Title = "Ivy" },
                        new { SongId = 30, AlbumId = 3, Title = "Pink + White" },
                        new { SongId = 31, AlbumId = 3, Title = "Be Yourself" },
                        new { SongId = 32, AlbumId = 3, Title = "Solo" },
                        new { SongId = 33, AlbumId = 3, Title = "Skyline To" },
                        new { SongId = 34, AlbumId = 3, Title = "Self Control" },
                        new { SongId = 35, AlbumId = 3, Title = "Good Guy" },
                        new { SongId = 36, AlbumId = 3, Title = "Nights" },
                        new { SongId = 37, AlbumId = 3, Title = "Solo (Reprise)" },
                        new { SongId = 38, AlbumId = 3, Title = "Pretty Sweet" },
                        new { SongId = 39, AlbumId = 3, Title = "Facebook Story" },
                        new { SongId = 40, AlbumId = 3, Title = "Closer To You" },
                        new { SongId = 41, AlbumId = 3, Title = "White Ferrari" },
                        new { SongId = 42, AlbumId = 3, Title = "Seigfried" },
                        new { SongId = 43, AlbumId = 3, Title = "Godspeed" },
                        new { SongId = 44, AlbumId = 3, Title = "Futara Free" }
                    );
                });

            modelBuilder.Entity("AlbumCollection.Models.Song", b =>
                {
                    b.HasOne("AlbumCollection.Models.Album", "Album")
                        .WithMany("Songs")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
