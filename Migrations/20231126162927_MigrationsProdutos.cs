using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebMercadoMVC.Migrations
{
    /// <inheritdoc />
    public partial class MigrationsProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    qtde = table.Column<int>(type: "int", nullable: false),
                    nome = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    preco = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
