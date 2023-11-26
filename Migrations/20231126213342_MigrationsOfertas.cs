using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebMercadoMVC.Migrations
{
    /// <inheritdoc />
    public partial class MigrationsOfertas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "oferta",
                table: "Ofertas",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "oferta",
                table: "Ofertas");
        }
    }
}
