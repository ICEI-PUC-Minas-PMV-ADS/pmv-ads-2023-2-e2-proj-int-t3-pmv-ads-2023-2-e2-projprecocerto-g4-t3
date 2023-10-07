using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrecoCerto.Migrations
{
    public partial class M04AddTableCarrinhoDeCompra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarrinhoDeCompras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValorTotal = table.Column<double>(type: "float", nullable: false),
                    QuantidadeItens = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarrinhoDeCompras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarrinhoDeCompras_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoDeCompras_UsuarioId",
                table: "CarrinhoDeCompras",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarrinhoDeCompras");
        }
    }
}
