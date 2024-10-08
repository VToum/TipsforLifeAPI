﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TipsforLifeAPI.Data;

#nullable disable

namespace TipsforLifeAPI.Migrations
{
    [DbContext(typeof(DicaContext))]
    partial class DicaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TipsforLifeAPI.Entidades.DicaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("SlipId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("SlipId");

                    b.ToTable("dicas");
                });

            modelBuilder.Entity("TipsforLifeAPI.Entidades.Slip", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Advice")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Slip");
                });

            modelBuilder.Entity("TipsforLifeAPI.Entidades.DicaModel", b =>
                {
                    b.HasOne("TipsforLifeAPI.Entidades.Slip", "Slip")
                        .WithMany()
                        .HasForeignKey("SlipId");

                    b.Navigation("Slip");
                });
#pragma warning restore 612, 618
        }
    }
}
