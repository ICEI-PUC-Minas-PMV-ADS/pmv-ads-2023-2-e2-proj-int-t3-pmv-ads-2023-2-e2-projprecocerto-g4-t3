using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrecoCerto.Migrations
{
    public partial class M10AddTableCarrinhoDeCompras2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "ValorTotal",
                table: "CarrinhoDeCompras",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<string>(
                name: "NomeProduto",
                table: "CarrinhoDeCompras",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomeProduto",
                table: "CarrinhoDeCompras");

            migrationBuilder.AlterColumn<double>(
                name: "ValorTotal",
                table: "CarrinhoDeCompras",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}
