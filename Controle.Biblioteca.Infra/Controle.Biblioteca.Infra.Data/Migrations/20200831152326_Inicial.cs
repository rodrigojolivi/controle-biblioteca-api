using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Controle.Biblioteca.Infra.Data.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autor",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    Descricao = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Livro",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Titulo = table.Column<string>(nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    Disponivel = table.Column<bool>(nullable: false),
                    IdAutor = table.Column<Guid>(nullable: false),
                    IdCategoria = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Livro_Autor_IdAutor",
                        column: x => x.IdAutor,
                        principalTable: "Autor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Livro_Categoria_IdCategoria",
                        column: x => x.IdCategoria,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Autor",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { new Guid("624896ea-0c0f-4415-a899-10b50f096146"), "Paulo Coelho" },
                    { new Guid("acb18b36-4f45-4a76-b3be-76406e5a7160"), "Eric Evans" }
                });

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Descricao", "Nome" },
                values: new object[,]
                {
                    { new Guid("bad95dd7-15e0-4c3f-8ec5-9f8e1dd11943"), "Livros de ficção", "Ficção" },
                    { new Guid("50ada5df-9e37-4e52-836b-89e9be0abf5c"), "Livros para estudos", "Estudo" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Livro_IdAutor",
                table: "Livro",
                column: "IdAutor");

            migrationBuilder.CreateIndex(
                name: "IX_Livro_IdCategoria",
                table: "Livro",
                column: "IdCategoria");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Livro");

            migrationBuilder.DropTable(
                name: "Autor");

            migrationBuilder.DropTable(
                name: "Categoria");
        }
    }
}
