﻿// <auto-generated />
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Data.Migrations
{
    [DbContext(typeof(OrdiniContext))]
    partial class OrdiniContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("API.Controllers.Prodotto", b =>
                {
                    b.Property<int>("ProdottoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Attivo")
                        .HasColumnType("TEXT");

                    b.Property<string>("CollegamentoImmagine")
                        .HasColumnType("TEXT");

                    b.Property<string>("DescrizioneProdotto")
                        .HasColumnType("TEXT");

                    b.Property<ushort>("IVA")
                        .HasColumnType("INTEGER");

                    b.Property<ushort>("Listino")
                        .HasColumnType("INTEGER");

                    b.Property<ushort>("PezziMax")
                        .HasColumnType("INTEGER");

                    b.Property<ushort>("PezziMin")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("PrezzoNetto")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("PrezzoPublico")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("PrezzoPublicoNoIva")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Sconto")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ScontoMax")
                        .HasColumnType("TEXT");

                    b.HasKey("ProdottoID");

                    b.ToTable("Prodotti");
                });
#pragma warning restore 612, 618
        }
    }
}