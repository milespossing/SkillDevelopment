﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmallGroupsSite.Models;

namespace SmallGroupsSite.Migrations
{
    [DbContext(typeof(SmallGroupsSiteContext))]
    [Migration("20180908175252_initial1")]
    partial class initial1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SmallGroupsSite.Models.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("ID");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("SmallGroupsSite.Models.PersonAddress", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("Line1");

                    b.Property<string>("Line2");

                    b.Property<int>("PersonID");

                    b.Property<string>("State");

                    b.Property<int>("ZipCode");

                    b.HasKey("ID");

                    b.HasIndex("PersonID");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("SmallGroupsSite.Models.PersonAddress", b =>
                {
                    b.HasOne("SmallGroupsSite.Models.Person", "Person")
                        .WithMany("Addresses")
                        .HasForeignKey("PersonID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
