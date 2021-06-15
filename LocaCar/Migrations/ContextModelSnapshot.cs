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
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("Model.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cpf")
                        .HasColumnType("longtext");

                    b.Property<string>("DataDeNascimento")
                        .HasColumnType("longtext");

                    b.Property<int>("DiasParaDevolucao")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("IdCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Model.Locacao", b =>
                {
                    b.Property<int>("IdLocacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ClienteIdCliente")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataLocacao")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.HasKey("IdLocacao");

                    b.HasIndex("ClienteIdCliente");

                    b.ToTable("Locacoes");
                });

            modelBuilder.Entity("Model.LocacaoVeiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdLocacao")
                        .HasColumnType("int");

                    b.Property<int>("IdVeiculo")
                        .HasColumnType("int");

                    b.Property<int?>("LocacaoIdLocacao")
                        .HasColumnType("int");

                    b.Property<int?>("VeiculoIdVeiculo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LocacaoIdLocacao");

                    b.HasIndex("VeiculoIdVeiculo");

                    b.ToTable("LocacaoVeiculo");
                });

            modelBuilder.Entity("Model.Veiculo", b =>
                {
                    b.Property<int>("IdVeiculo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Ano")
                        .HasColumnType("longtext");

                    b.Property<string>("Cor")
                        .HasColumnType("longtext");

                    b.Property<string>("Marca")
                        .HasColumnType("longtext");

                    b.Property<string>("Modelo")
                        .HasColumnType("longtext");

                    b.Property<double>("Preco")
                        .HasColumnType("double");

                    b.Property<string>("Restricao")
                        .HasColumnType("longtext");

                    b.HasKey("IdVeiculo");

                    b.ToTable("Veiculos");
                });

            modelBuilder.Entity("Model.Locacao", b =>
                {
                    b.HasOne("Model.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteIdCliente");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Model.LocacaoVeiculo", b =>
                {
                    b.HasOne("Model.Locacao", "Locacao")
                        .WithMany()
                        .HasForeignKey("LocacaoIdLocacao");

                    b.HasOne("Model.Veiculo", "Veiculo")
                        .WithMany()
                        .HasForeignKey("VeiculoIdVeiculo");

                    b.Navigation("Locacao");

                    b.Navigation("Veiculo");
                });
#pragma warning restore 612, 618
        }
    }
}
