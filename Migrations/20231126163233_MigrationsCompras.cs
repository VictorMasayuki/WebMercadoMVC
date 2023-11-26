using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebMercadoMVC.Migrations
{
    /// <inheritdoc />
    public partial class MigrationsCompras : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Compras",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clienteid = table.Column<int>(type: "int", nullable: false),
                    produtoid = table.Column<int>(type: "int", nullable: false),
                    quantidaderequisitada = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras", x => x.id);
                    table.ForeignKey(
                        name: "FK_Compras_Clientes_clienteid",
                        column: x => x.clienteid,
                        principalTable: "Clientes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Compras_Produtos_produtoid",
                        column: x => x.produtoid,
                        principalTable: "Produtos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Compras_clienteid",
                table: "Compras",
                column: "clienteid");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_produtoid",
                table: "Compras",
                column: "produtoid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Compras");
        }
    }
}
