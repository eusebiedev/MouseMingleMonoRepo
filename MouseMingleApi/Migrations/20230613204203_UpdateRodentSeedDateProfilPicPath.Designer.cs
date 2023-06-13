﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MouseMingleApi.Models;

#nullable disable

namespace MouseMingle.Migrations
{
    [DbContext(typeof(MouseMingleApiContext))]
    [Migration("20230613204203_UpdateRodentSeedDateProfilPicPath")]
    partial class UpdateRodentSeedDateProfilPicPath
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MouseMingleApi.Models.Interest", b =>
                {
                    b.Property<int>("InterestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.HasKey("InterestId");

                    b.ToTable("Interests");

                    b.HasData(
                        new
                        {
                            InterestId = 1,
                            Description = "Sipping water"
                        },
                        new
                        {
                            InterestId = 2,
                            Description = "Styrofoam"
                        },
                        new
                        {
                            InterestId = 3,
                            Description = "Old peanuts"
                        },
                        new
                        {
                            InterestId = 4,
                            Description = "Long walks under the boardwalk"
                        },
                        new
                        {
                            InterestId = 5,
                            Description = "Wet old towels"
                        },
                        new
                        {
                            InterestId = 6,
                            Description = "Cheese scraps"
                        },
                        new
                        {
                            InterestId = 7,
                            Description = "Meat sticks"
                        },
                        new
                        {
                            InterestId = 8,
                            Description = "Shards"
                        },
                        new
                        {
                            InterestId = 9,
                            Description = "Clam shells"
                        },
                        new
                        {
                            InterestId = 10,
                            Description = "Dirt blood"
                        });
                });

            modelBuilder.Entity("MouseMingleApi.Models.Rodent", b =>
                {
                    b.Property<int>("RodentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("ProfilePic")
                        .HasColumnType("longtext");

                    b.Property<string>("Species")
                        .HasColumnType("longtext");

                    b.HasKey("RodentId");

                    b.ToTable("Rodents");

                    b.HasData(
                        new
                        {
                            RodentId = 1,
                            Age = 43,
                            Location = "Fishermans Warf No.3",
                            Name = "Scorpo Fangoria",
                            ProfilePic = "~/profiles/scorpo.gif",
                            Species = "Rat"
                        },
                        new
                        {
                            RodentId = 2,
                            Age = 33,
                            Location = "In a van down by the river",
                            Name = "Cadder Jenks",
                            ProfilePic = "~/profiles/cadder.gif",
                            Species = "Rat"
                        },
                        new
                        {
                            RodentId = 3,
                            Age = 18,
                            Location = "hole",
                            Name = "Flippy Twitch",
                            ProfilePic = "~/profiles/flippy.gif",
                            Species = "Mouse"
                        },
                        new
                        {
                            RodentId = 4,
                            Age = 23,
                            Location = "hole",
                            Name = "Patty Valentine",
                            ProfilePic = "~/profiles/patty.gif",
                            Species = "Mouse"
                        },
                        new
                        {
                            RodentId = 5,
                            Age = 58,
                            Location = "hole",
                            Name = "Alfred Bello Twitch",
                            ProfilePic = "~/profiles/alfred.gif",
                            Species = "Naked Molerat"
                        },
                        new
                        {
                            RodentId = 6,
                            Age = 19,
                            Location = "hole",
                            Name = "Rubin Carter",
                            ProfilePic = "~/profiles/rubin.gif",
                            Species = "Ferret"
                        },
                        new
                        {
                            RodentId = 7,
                            Age = 28,
                            Location = "hole",
                            Name = "Arthur Dexter Bradley",
                            ProfilePic = "~/profiles/arthur.gif",
                            Species = "Capybara"
                        },
                        new
                        {
                            RodentId = 8,
                            Age = 29,
                            Location = "hole",
                            Name = "Squanker Classic",
                            ProfilePic = "~/profiles/squanker.gif",
                            Species = "Guinea Pig"
                        },
                        new
                        {
                            RodentId = 9,
                            Age = 88,
                            Location = "hole",
                            Name = "Big Daddy Crawford",
                            ProfilePic = "~/profiles/daddy.gif",
                            Species = "Myomorpha"
                        },
                        new
                        {
                            RodentId = 10,
                            Age = 35,
                            Location = "hole",
                            Name = "House Mouse",
                            ProfilePic = "~/profiles/housemouse.gif",
                            Species = "Mus Musculus"
                        });
                });

            modelBuilder.Entity("MouseMingleApi.Models.RodentInterest", b =>
                {
                    b.Property<int>("RodentInterestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("InterestId")
                        .HasColumnType("int");

                    b.Property<int>("RodentId")
                        .HasColumnType("int");

                    b.HasKey("RodentInterestId");

                    b.HasIndex("InterestId");

                    b.HasIndex("RodentId");

                    b.ToTable("RodentInterests");

                    b.HasData(
                        new
                        {
                            RodentInterestId = 1,
                            InterestId = 1,
                            RodentId = 1
                        },
                        new
                        {
                            RodentInterestId = 2,
                            InterestId = 6,
                            RodentId = 1
                        },
                        new
                        {
                            RodentInterestId = 3,
                            InterestId = 2,
                            RodentId = 2
                        },
                        new
                        {
                            RodentInterestId = 4,
                            InterestId = 3,
                            RodentId = 2
                        },
                        new
                        {
                            RodentInterestId = 5,
                            InterestId = 4,
                            RodentId = 3
                        },
                        new
                        {
                            RodentInterestId = 6,
                            InterestId = 5,
                            RodentId = 3
                        },
                        new
                        {
                            RodentInterestId = 7,
                            InterestId = 10,
                            RodentId = 4
                        },
                        new
                        {
                            RodentInterestId = 8,
                            InterestId = 8,
                            RodentId = 4
                        },
                        new
                        {
                            RodentInterestId = 9,
                            InterestId = 9,
                            RodentId = 5
                        },
                        new
                        {
                            RodentInterestId = 10,
                            InterestId = 7,
                            RodentId = 5
                        },
                        new
                        {
                            RodentInterestId = 11,
                            InterestId = 2,
                            RodentId = 6
                        },
                        new
                        {
                            RodentInterestId = 12,
                            InterestId = 7,
                            RodentId = 6
                        },
                        new
                        {
                            RodentInterestId = 13,
                            InterestId = 9,
                            RodentId = 7
                        },
                        new
                        {
                            RodentInterestId = 14,
                            InterestId = 1,
                            RodentId = 7
                        },
                        new
                        {
                            RodentInterestId = 15,
                            InterestId = 5,
                            RodentId = 8
                        },
                        new
                        {
                            RodentInterestId = 16,
                            InterestId = 3,
                            RodentId = 8
                        },
                        new
                        {
                            RodentInterestId = 17,
                            InterestId = 10,
                            RodentId = 9
                        },
                        new
                        {
                            RodentInterestId = 18,
                            InterestId = 7,
                            RodentId = 9
                        },
                        new
                        {
                            RodentInterestId = 19,
                            InterestId = 2,
                            RodentId = 10
                        },
                        new
                        {
                            RodentInterestId = 20,
                            InterestId = 8,
                            RodentId = 10
                        });
                });

            modelBuilder.Entity("MouseMingleApi.Models.RodentInterest", b =>
                {
                    b.HasOne("MouseMingleApi.Models.Interest", null)
                        .WithMany("RodentInterests")
                        .HasForeignKey("InterestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MouseMingleApi.Models.Rodent", null)
                        .WithMany("RodentInterests")
                        .HasForeignKey("RodentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MouseMingleApi.Models.Interest", b =>
                {
                    b.Navigation("RodentInterests");
                });

            modelBuilder.Entity("MouseMingleApi.Models.Rodent", b =>
                {
                    b.Navigation("RodentInterests");
                });
#pragma warning restore 612, 618
        }
    }
}
