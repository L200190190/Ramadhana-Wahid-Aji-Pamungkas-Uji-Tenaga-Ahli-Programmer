﻿// <auto-generated />
using MahasiswaAPI.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MahasiswaAPI.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20240206084209_migrasi_database_pertama")]
    partial class migrasi_database_pertama
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MahasiswaAPI.Models.Mahasiswa", b =>
                {
                    b.Property<string>("Nobp")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Alamat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("JenisKelamin")
                        .HasColumnType("int");

                    b.Property<string>("Nama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nohp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Nobp");

                    b.ToTable("Tb_M_Mahasiswa");
                });
#pragma warning restore 612, 618
        }
    }
}
