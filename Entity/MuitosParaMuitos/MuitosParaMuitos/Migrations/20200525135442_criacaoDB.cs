﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace MuitosParaMuitos.Migrations
{
    public partial class criacaoDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empregados",
                columns: table => new
                {
                    EmpregadoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Idade = table.Column<int>(nullable: false),
                    CPF = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empregados", x => x.EmpregadoId);
                });

            migrationBuilder.CreateTable(
                name: "Trabalhos",
                columns: table => new
                {
                    TrabalhoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trabalhos", x => x.TrabalhoId);
                });

            migrationBuilder.CreateTable(
                name: "EmpregoTrabalhos",
                columns: table => new
                {
                    EmpregadoId = table.Column<int>(nullable: false),
                    TrabalhoId = table.Column<int>(nullable: false),
                    CargaHoraria = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpregoTrabalhos", x => new { x.EmpregadoId, x.TrabalhoId });
                    table.ForeignKey(
                        name: "FK_EmpregoTrabalhos_Empregados_EmpregadoId",
                        column: x => x.EmpregadoId,
                        principalTable: "Empregados",
                        principalColumn: "EmpregadoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmpregoTrabalhos_Trabalhos_TrabalhoId",
                        column: x => x.TrabalhoId,
                        principalTable: "Trabalhos",
                        principalColumn: "TrabalhoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmpregoTrabalhos_TrabalhoId",
                table: "EmpregoTrabalhos",
                column: "TrabalhoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpregoTrabalhos");

            migrationBuilder.DropTable(
                name: "Empregados");

            migrationBuilder.DropTable(
                name: "Trabalhos");
        }
    }
}
