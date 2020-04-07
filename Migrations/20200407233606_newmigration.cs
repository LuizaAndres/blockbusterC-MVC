using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace blockbusterC_MVC.Migrations
{
    public partial class newmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locacoes_Filmes_FilmeId",
                table: "Locacoes");

            migrationBuilder.DropIndex(
                name: "IX_Locacoes_FilmeId",
                table: "Locacoes");

            migrationBuilder.DropColumn(
                name: "DataLocacao",
                table: "Locacoes");

            migrationBuilder.DropColumn(
                name: "FilmeId",
                table: "Locacoes");

            migrationBuilder.DropColumn(
                name: "QtdDias",
                table: "Clientes");

            migrationBuilder.AddColumn<DateTime>(
                name: "DtLocacao",
                table: "Locacoes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "NomeFilme",
                table: "Filmes",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Dias",
                table: "Clientes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "FilmeLocacao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FilmeId = table.Column<int>(nullable: false),
                    LocacaoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmeLocacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FilmeLocacao_Filmes_FilmeId",
                        column: x => x.FilmeId,
                        principalTable: "Filmes",
                        principalColumn: "FilmeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmeLocacao_Locacoes_LocacaoId",
                        column: x => x.LocacaoId,
                        principalTable: "Locacoes",
                        principalColumn: "LocacaoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FilmeLocacao_FilmeId",
                table: "FilmeLocacao",
                column: "FilmeId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmeLocacao_LocacaoId",
                table: "FilmeLocacao",
                column: "LocacaoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmeLocacao");

            migrationBuilder.DropColumn(
                name: "DtLocacao",
                table: "Locacoes");

            migrationBuilder.DropColumn(
                name: "Dias",
                table: "Clientes");

            migrationBuilder.AddColumn<string>(
                name: "DataLocacao",
                table: "Locacoes",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FilmeId",
                table: "Locacoes",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NomeFilme",
                table: "Filmes",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QtdDias",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Locacoes_FilmeId",
                table: "Locacoes",
                column: "FilmeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Locacoes_Filmes_FilmeId",
                table: "Locacoes",
                column: "FilmeId",
                principalTable: "Filmes",
                principalColumn: "FilmeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
