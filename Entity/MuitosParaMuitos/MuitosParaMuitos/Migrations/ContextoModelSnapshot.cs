﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MuitosParaMuitos.Models;

namespace MuitosParaMuitos.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MuitosParaMuitos.Models.Empregado", b =>
                {
                    b.Property<int>("EmpregadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmpregadoId");

                    b.ToTable("Empregados");
                });

            modelBuilder.Entity("MuitosParaMuitos.Models.EmpregoTrabalho", b =>
                {
                    b.Property<int>("EmpregadoId")
                        .HasColumnType("int");

                    b.Property<int>("TrabalhoId")
                        .HasColumnType("int");

                    b.Property<int>("CargaHoraria")
                        .HasColumnType("int");

                    b.HasKey("EmpregadoId", "TrabalhoId");

                    b.HasIndex("TrabalhoId");

                    b.ToTable("EmpregoTrabalhos");
                });

            modelBuilder.Entity("MuitosParaMuitos.Models.Trabalho", b =>
                {
                    b.Property<int>("TrabalhoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TrabalhoId");

                    b.ToTable("Trabalhos");
                });

            modelBuilder.Entity("MuitosParaMuitos.Models.EmpregoTrabalho", b =>
                {
                    b.HasOne("MuitosParaMuitos.Models.Empregado", "Empregado")
                        .WithMany("EmpregoTrabalhos")
                        .HasForeignKey("EmpregadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MuitosParaMuitos.Models.Trabalho", "Trabalho")
                        .WithMany("EmpregoTrabalhos")
                        .HasForeignKey("TrabalhoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
