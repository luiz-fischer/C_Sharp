﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

namespace LocaCar.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Model.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataDeNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("DiasParaDevolucao")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Model.Locacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataDeLocacao")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Locacoes");
                });

            modelBuilder.Entity("Model.LocacaoVeiculoLeve", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<int>("LocacaoId")
                        .HasColumnType("int");

                    b.Property<int>("VeiculoLeveId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LocacaoId");

                    b.HasIndex("VeiculoLeveId");

                    b.ToTable("LocacoesVeiculosLeve");
                });

            modelBuilder.Entity("Model.LocacaoVeiculoPesado", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<int>("LocacaoId")
                        .HasColumnType("int");

                    b.Property<int>("VeiculoPesadoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LocacaoId");

                    b.HasIndex("VeiculoPesadoId");

                    b.ToTable("LocacoesVeiculosPesado");
                });

            modelBuilder.Entity("Model.VeiculoLeve", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<string>("Cor")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Marca")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Modelo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("Preco")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("VeiculosLeve");
                });

            modelBuilder.Entity("Model.VeiculoPesado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Modelo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("Preco")
                        .HasColumnType("double");

                    b.Property<string>("Restricoes")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("VeiculosPesado");
                });

            modelBuilder.Entity("Model.Locacao", b =>
                {
                    b.HasOne("Model.Cliente", "Cliente")
                        .WithMany("Locacoes")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.LocacaoVeiculoLeve", b =>
                {
                    b.HasOne("Model.Locacao", "Locacao")
                        .WithMany("VeiculosLeve")
                        .HasForeignKey("LocacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.VeiculoLeve", "VeiculoLeve")
                        .WithMany()
                        .HasForeignKey("VeiculoLeveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.LocacaoVeiculoPesado", b =>
                {
                    b.HasOne("Model.Locacao", "Locacao")
                        .WithMany("VeiculosPesado")
                        .HasForeignKey("LocacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.VeiculoPesado", "VeiculoPesado")
                        .WithMany("Locacoes")
                        .HasForeignKey("VeiculoPesadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
