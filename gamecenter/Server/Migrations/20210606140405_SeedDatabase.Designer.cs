﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using gamecenter.Server.Data;

namespace gamecenter.Server.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210606140405_SeedDatabase")]
    partial class SeedDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("gamecenter.Shared.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("NewlyReleases")
                        .HasColumnType("bit");

                    b.Property<string>("Poster")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ReleaseDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trailer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NewlyReleases = false,
                            Poster = "Images/Game/RedDeadRedemption.jpg",
                            ReleaseDate = new DateTime(2011, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Summary = "* Red Dead Redemption",
                            Title = "Red Dead Redemption",
                            Trailer = ""
                        },
                        new
                        {
                            Id = 2,
                            NewlyReleases = true,
                            Poster = "Images/Game/RedDeadRedemption-2.jpg",
                            ReleaseDate = new DateTime(2018, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Summary = "* Red Dead Redemption 2",
                            Title = "Red Dead Redemption 2",
                            Trailer = "SXvQ1nK4oxk"
                        },
                        new
                        {
                            Id = 3,
                            NewlyReleases = false,
                            Poster = "Images/Game/LittleNightmares-1.jpg",
                            ReleaseDate = new DateTime(2017, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Summary = "* Little Nightmares",
                            Title = "Little Nightmares",
                            Trailer = "aOadxZBsPiA"
                        },
                        new
                        {
                            Id = 4,
                            NewlyReleases = true,
                            Poster = "Images/Game/LittleNightmares-2.jpg",
                            ReleaseDate = new DateTime(2021, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Summary = "* Little Nightmares 2",
                            Title = "Little Nightmares 2",
                            Trailer = "AI9zBBTyX-E"
                        },
                        new
                        {
                            Id = 5,
                            NewlyReleases = false,
                            Poster = "Images/Game/AssassinsCreed-Odyssey.jpg",
                            ReleaseDate = new DateTime(2018, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Summary = "* Assassins Creed - Odyssey",
                            Title = "Assassins Creed - Odyssey",
                            Trailer = "s_SJZSAtLBA"
                        },
                        new
                        {
                            Id = 6,
                            NewlyReleases = true,
                            Poster = "Images/Game/AssassinsCreed-Valhalla.jpg",
                            ReleaseDate = new DateTime(2021, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Summary = "* Assassins Creed - Valhalla",
                            Title = "Assassins Creed - Valhalla",
                            Trailer = "z-r2AhqxBzw"
                        },
                        new
                        {
                            Id = 7,
                            NewlyReleases = false,
                            Poster = "Images/Game/TheWitcher-WildHunt.jpg",
                            ReleaseDate = new DateTime(2050, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Summary = "* The Witcher 3 - Wild Hunt",
                            Title = "The Witcher 3 - Wild Hunt",
                            Trailer = "c0i88t0Kacs"
                        });
                });

            modelBuilder.Entity("gamecenter.Shared.Models.GameRating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<DateTime>("RatingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("GameRatings");
                });

            modelBuilder.Entity("gamecenter.Shared.Models.GamesGenres", b =>
                {
                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.HasKey("GameId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("GamesGenres");

                    b.HasData(
                        new
                        {
                            GameId = 6,
                            GenreId = 3
                        },
                        new
                        {
                            GameId = 6,
                            GenreId = 4
                        },
                        new
                        {
                            GameId = 6,
                            GenreId = 9
                        },
                        new
                        {
                            GameId = 5,
                            GenreId = 3
                        },
                        new
                        {
                            GameId = 5,
                            GenreId = 5
                        },
                        new
                        {
                            GameId = 5,
                            GenreId = 9
                        },
                        new
                        {
                            GameId = 3,
                            GenreId = 1
                        },
                        new
                        {
                            GameId = 3,
                            GenreId = 2
                        },
                        new
                        {
                            GameId = 3,
                            GenreId = 3
                        },
                        new
                        {
                            GameId = 3,
                            GenreId = 8
                        },
                        new
                        {
                            GameId = 4,
                            GenreId = 1
                        },
                        new
                        {
                            GameId = 4,
                            GenreId = 2
                        },
                        new
                        {
                            GameId = 4,
                            GenreId = 3
                        },
                        new
                        {
                            GameId = 4,
                            GenreId = 8
                        },
                        new
                        {
                            GameId = 1,
                            GenreId = 6
                        },
                        new
                        {
                            GameId = 1,
                            GenreId = 7
                        },
                        new
                        {
                            GameId = 1,
                            GenreId = 9
                        },
                        new
                        {
                            GameId = 2,
                            GenreId = 6
                        },
                        new
                        {
                            GameId = 2,
                            GenreId = 7
                        },
                        new
                        {
                            GameId = 2,
                            GenreId = 9
                        },
                        new
                        {
                            GameId = 7,
                            GenreId = 3
                        },
                        new
                        {
                            GameId = 7,
                            GenreId = 9
                        });
                });

            modelBuilder.Entity("gamecenter.Shared.Models.GamesPeople", b =>
                {
                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("RoleOfGame")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameId", "PersonId");

                    b.HasIndex("PersonId");

                    b.ToTable("GamesPeople");

                    b.HasData(
                        new
                        {
                            GameId = 1,
                            PersonId = 1,
                            Order = 2,
                            RoleOfGame = "Programmer"
                        },
                        new
                        {
                            GameId = 2,
                            PersonId = 1,
                            Order = 3,
                            RoleOfGame = "Programmer"
                        },
                        new
                        {
                            GameId = 3,
                            PersonId = 1,
                            Order = 2,
                            RoleOfGame = "Programmer"
                        },
                        new
                        {
                            GameId = 4,
                            PersonId = 1,
                            Order = 2,
                            RoleOfGame = "Programmer"
                        },
                        new
                        {
                            GameId = 5,
                            PersonId = 1,
                            Order = 2,
                            RoleOfGame = "Programmer"
                        },
                        new
                        {
                            GameId = 6,
                            PersonId = 1,
                            Order = 2,
                            RoleOfGame = "Programmer"
                        },
                        new
                        {
                            GameId = 7,
                            PersonId = 1,
                            Order = 2,
                            RoleOfGame = "Programmer"
                        },
                        new
                        {
                            GameId = 1,
                            PersonId = 6,
                            Order = 1,
                            RoleOfGame = "John Marston"
                        },
                        new
                        {
                            GameId = 2,
                            PersonId = 6,
                            Order = 2,
                            RoleOfGame = "John Marston"
                        },
                        new
                        {
                            GameId = 2,
                            PersonId = 5,
                            Order = 1,
                            RoleOfGame = "Arthur Morgan"
                        },
                        new
                        {
                            GameId = 3,
                            PersonId = 2,
                            Order = 1,
                            RoleOfGame = "Six"
                        },
                        new
                        {
                            GameId = 4,
                            PersonId = 2,
                            Order = 1,
                            RoleOfGame = "Six / Mono"
                        },
                        new
                        {
                            GameId = 5,
                            PersonId = 4,
                            Order = 1,
                            RoleOfGame = "Alexios"
                        },
                        new
                        {
                            GameId = 6,
                            PersonId = 3,
                            Order = 1,
                            RoleOfGame = "Eivor Wolf-Kissed"
                        },
                        new
                        {
                            GameId = 7,
                            PersonId = 7,
                            Order = 1,
                            RoleOfGame = "Geralt of Rivia"
                        });
                });

            modelBuilder.Entity("gamecenter.Shared.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Thriller"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Norse Mythology"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Acient Greek"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Western"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Platform"
                        },
                        new
                        {
                            Id = 9,
                            Name = "RPG"
                        });
                });

            modelBuilder.Entity("gamecenter.Shared.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Biography")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateOfBirth")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Biography = "* Ulrik Rosberg",
                            DateOfBirth = new DateTime(1993, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Ulrik Rosberg",
                            Picture = "Images/Person/UlrikRosberg.jpg"
                        },
                        new
                        {
                            Id = 2,
                            Biography = "* Anna Moberg",
                            DateOfBirth = new DateTime(1998, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Anna Moberg",
                            Picture = "Images/Person/AnnaMoberg.jpg"
                        },
                        new
                        {
                            Id = 3,
                            Biography = "* Magnus Bruun",
                            DateOfBirth = new DateTime(1993, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Magnus Bruun",
                            Picture = "Images/Person/MagnusBruun.jpg"
                        },
                        new
                        {
                            Id = 4,
                            Biography = "* Michael Antanakos",
                            DateOfBirth = new DateTime(1980, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Michael Antonakos",
                            Picture = "Images/Person/MichaelAntonakos.jpg"
                        },
                        new
                        {
                            Id = 5,
                            Biography = "* Roger Clark",
                            DateOfBirth = new DateTime(1978, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Roger Clark",
                            Picture = "Images/Person/RogerClark.jpg"
                        },
                        new
                        {
                            Id = 6,
                            Biography = "* Robert Wiethoff",
                            DateOfBirth = new DateTime(1978, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Rob Wiethoff",
                            Picture = "Images/Person/RobWiethoff.jpg"
                        },
                        new
                        {
                            Id = 7,
                            Biography = "* Doug Cockle",
                            DateOfBirth = new DateTime(1978, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Doug Cockle",
                            Picture = "Images/Person/DougCockle.jpg"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("gamecenter.Shared.Models.GameRating", b =>
                {
                    b.HasOne("gamecenter.Shared.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("gamecenter.Shared.Models.GamesGenres", b =>
                {
                    b.HasOne("gamecenter.Shared.Models.Game", "Game")
                        .WithMany("GamesGenres")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("gamecenter.Shared.Models.Genre", "Genre")
                        .WithMany("GamesGenres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("gamecenter.Shared.Models.GamesPeople", b =>
                {
                    b.HasOne("gamecenter.Shared.Models.Game", "Game")
                        .WithMany("GamesPeople")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("gamecenter.Shared.Models.Person", "Person")
                        .WithMany("GamesPeople")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("gamecenter.Shared.Models.Game", b =>
                {
                    b.Navigation("GamesGenres");

                    b.Navigation("GamesPeople");
                });

            modelBuilder.Entity("gamecenter.Shared.Models.Genre", b =>
                {
                    b.Navigation("GamesGenres");
                });

            modelBuilder.Entity("gamecenter.Shared.Models.Person", b =>
                {
                    b.Navigation("GamesPeople");
                });
#pragma warning restore 612, 618
        }
    }
}
