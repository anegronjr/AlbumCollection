﻿// <auto-generated />
using AlbumCollection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AlbumCollection.Migrations
{
    [DbContext(typeof(AlbumContext))]
    [Migration("20190308203948_AddedSongSeedData")]
    partial class AddedSongSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AlbumCollection.Models.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Artist");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Albums");

                    b.HasData(
                        new { Id = 1, Artist = "Frank Ocean", Title = "Nostalgia, Ultra" },
                        new { Id = 2, Artist = "Frank Ocean", Title = "Channel Orange" },
                        new { Id = 3, Artist = "Frank Ocean", Title = "Blonde" }
                    );
                });

            modelBuilder.Entity("AlbumCollection.Models.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.ToTable("Songs");

                    b.HasData(
                        new { Id = 1, AlbumId = 1, Title = "Strawberry Swing" },
                        new { Id = 2, AlbumId = 1, Title = "Novacane" },
                        new { Id = 3, AlbumId = 1, Title = "We All Try" },
                        new { Id = 4, AlbumId = 1, Title = "Songs 4 Women" },
                        new { Id = 5, AlbumId = 1, Title = "Lovecrimes" },
                        new { Id = 6, AlbumId = 1, Title = "There Will Be Tears" },
                        new { Id = 7, AlbumId = 1, Title = "Swim Good" },
                        new { Id = 8, AlbumId = 1, Title = "Dust" },
                        new { Id = 9, AlbumId = 1, Title = "American Wedding" },
                        new { Id = 10, AlbumId = 1, Title = "Nature Feels" },
                        new { Id = 11, AlbumId = 2, Title = "Start" },
                        new { Id = 12, AlbumId = 2, Title = "Thinkin' 'Bout You" },
                        new { Id = 13, AlbumId = 2, Title = "Fertilizer" },
                        new { Id = 14, AlbumId = 2, Title = "Sierra Leone" },
                        new { Id = 15, AlbumId = 2, Title = "Sweet Life" },
                        new { Id = 16, AlbumId = 2, Title = "Not Just Money" },
                        new { Id = 17, AlbumId = 2, Title = "Super Rich Kids" },
                        new { Id = 18, AlbumId = 2, Title = "Pilot Jones" },
                        new { Id = 19, AlbumId = 2, Title = "Crack Rock" },
                        new { Id = 20, AlbumId = 2, Title = "Pyramids" },
                        new { Id = 21, AlbumId = 2, Title = "Lost" },
                        new { Id = 22, AlbumId = 2, Title = "White" },
                        new { Id = 23, AlbumId = 2, Title = "Monks" },
                        new { Id = 24, AlbumId = 2, Title = "Bad Religion" },
                        new { Id = 25, AlbumId = 2, Title = "Pink Matter" },
                        new { Id = 26, AlbumId = 2, Title = "Forrest Gump" },
                        new { Id = 27, AlbumId = 2, Title = "End" },
                        new { Id = 28, AlbumId = 3, Title = "Nikes" },
                        new { Id = 29, AlbumId = 3, Title = "Ivy" },
                        new { Id = 30, AlbumId = 3, Title = "Pink + White" },
                        new { Id = 31, AlbumId = 3, Title = "Be Yourself" },
                        new { Id = 32, AlbumId = 3, Title = "Solo" },
                        new { Id = 33, AlbumId = 3, Title = "Skyline To" },
                        new { Id = 34, AlbumId = 3, Title = "Self Control" },
                        new { Id = 35, AlbumId = 3, Title = "Good Guy" },
                        new { Id = 36, AlbumId = 3, Title = "Nights" },
                        new { Id = 37, AlbumId = 3, Title = "Solo (Reprise)" },
                        new { Id = 38, AlbumId = 3, Title = "Pretty Sweet" },
                        new { Id = 39, AlbumId = 3, Title = "Facebook Story" },
                        new { Id = 40, AlbumId = 3, Title = "Closer To You" },
                        new { Id = 41, AlbumId = 3, Title = "White Ferrari" },
                        new { Id = 42, AlbumId = 3, Title = "Seigfried" },
                        new { Id = 43, AlbumId = 3, Title = "Godspeed" },
                        new { Id = 44, AlbumId = 3, Title = "Futara Free" }
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
