﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proiect_Nohai.Data;

namespace Proiect_Nohai.Migrations
{
    [DbContext(typeof(Proiect_NohaiContext))]
    partial class Proiect_NohaiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Proiect_Nohai.Models.Bilet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BileteCumparate")
                        .HasColumnType("int");

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataJocului")
                        .HasColumnType("datetime2");

                    b.Property<string>("EchipaGazda")
                        .IsRequired()
                        .HasColumnType("nvarchar(70)")
                        .HasMaxLength(70);

                    b.Property<string>("EchipaOaspete")
                        .IsRequired()
                        .HasColumnType("nvarchar(70)")
                        .HasMaxLength(70);

                    b.Property<decimal>("Pret")
                        .HasColumnType("decimal(6, 2)");

                    b.HasKey("ID");

                    b.HasIndex("ClientID");

                    b.ToTable("Bilet");
                });

            modelBuilder.Entity("Proiect_Nohai.Models.Client", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NumeClient")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("ReducereID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ReducereID");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("Proiect_Nohai.Models.Reducere", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TipReducere")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Reducere");
                });

            modelBuilder.Entity("Proiect_Nohai.Models.Bilet", b =>
                {
                    b.HasOne("Proiect_Nohai.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Proiect_Nohai.Models.Client", b =>
                {
                    b.HasOne("Proiect_Nohai.Models.Reducere", "Reducere")
                        .WithMany()
                        .HasForeignKey("ReducereID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
