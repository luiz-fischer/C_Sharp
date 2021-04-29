using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LocaCar.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    DataDeNascimento = table.Column<DateTime>(nullable: false),
                    DiasParaDevolucao = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VeiculosLeve",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Marca = table.Column<string>(nullable: true),
                    Modelo = table.Column<string>(nullable: true),
                    Ano = table.Column<int>(nullable: false),
                    Preco = table.Column<double>(nullable: false),
                    Cor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VeiculosLeve", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VeiculosPesado",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Marca = table.Column<string>(nullable: true),
                    Modelo = table.Column<string>(nullable: true),
                    Ano = table.Column<int>(nullable: false),
                    Preco = table.Column<double>(nullable: false),
                    Restricoes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VeiculosPesado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locacoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClienteId = table.Column<int>(nullable: false),
                    DataDeLocacao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locacoes_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocacoesVeiculosLeve",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LocacaoId = table.Column<int>(nullable: false),
                    VeiculoLeveId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocacoesVeiculosLeve", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocacoesVeiculosLeve_Locacoes_LocacaoId",
                        column: x => x.LocacaoId,
                        principalTable: "Locacoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocacoesVeiculosLeve_VeiculosLeve_VeiculoLeveId",
                        column: x => x.VeiculoLeveId,
                        principalTable: "VeiculosLeve",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocacoesVeiculosPesado",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LocacaoId = table.Column<int>(nullable: false),
                    VeiculoPesadoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocacoesVeiculosPesado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocacoesVeiculosPesado_Locacoes_LocacaoId",
                        column: x => x.LocacaoId,
                        principalTable: "Locacoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocacoesVeiculosPesado_VeiculosPesado_VeiculoPesadoId",
                        column: x => x.VeiculoPesadoId,
                        principalTable: "VeiculosPesado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Locacoes_ClienteId",
                table: "Locacoes",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_LocacoesVeiculosLeve_LocacaoId",
                table: "LocacoesVeiculosLeve",
                column: "LocacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_LocacoesVeiculosLeve_VeiculoLeveId",
                table: "LocacoesVeiculosLeve",
                column: "VeiculoLeveId");

            migrationBuilder.CreateIndex(
                name: "IX_LocacoesVeiculosPesado_LocacaoId",
                table: "LocacoesVeiculosPesado",
                column: "LocacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_LocacoesVeiculosPesado_VeiculoPesadoId",
                table: "LocacoesVeiculosPesado",
                column: "VeiculoPesadoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocacoesVeiculosLeve");

            migrationBuilder.DropTable(
                name: "LocacoesVeiculosPesado");

            migrationBuilder.DropTable(
                name: "VeiculosLeve");

            migrationBuilder.DropTable(
                name: "Locacoes");

            migrationBuilder.DropTable(
                name: "VeiculosPesado");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
