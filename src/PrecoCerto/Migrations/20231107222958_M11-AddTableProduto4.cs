using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrecoCerto.Migrations
{
    public partial class M11AddTableProduto4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Imagem",
                table: "Produtos",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "ImagemMimeType",
                table: "Produtos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "ModalImagem",
                table: "Produtos",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModalImagemMimeType",
                table: "Produtos",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagem",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "ImagemMimeType",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "ModalImagem",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "ModalImagemMimeType",
                table: "Produtos");
        }
    }
}
