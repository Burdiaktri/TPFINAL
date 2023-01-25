using Microsoft.EntityFrameworkCore.Migrations;

namespace SWProvincias_Apellido.Migrations
{
    public partial class changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ciudades_Provincias_ProvinciaId",
                table: "Ciudades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Provincias",
                table: "Provincias");

            migrationBuilder.DropColumn(
                name: "IdCiudad",
                table: "Provincias");

            migrationBuilder.AddColumn<int>(
                name: "IdProvincia",
                table: "Provincias",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Provincias",
                table: "Provincias",
                column: "IdProvincia");

            migrationBuilder.AddForeignKey(
                name: "FK_Ciudades_Provincias_ProvinciaId",
                table: "Ciudades",
                column: "ProvinciaId",
                principalTable: "Provincias",
                principalColumn: "IdProvincia",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ciudades_Provincias_ProvinciaId",
                table: "Ciudades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Provincias",
                table: "Provincias");

            migrationBuilder.DropColumn(
                name: "IdProvincia",
                table: "Provincias");

            migrationBuilder.AddColumn<int>(
                name: "IdCiudad",
                table: "Provincias",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Provincias",
                table: "Provincias",
                column: "IdCiudad");

            migrationBuilder.AddForeignKey(
                name: "FK_Ciudades_Provincias_ProvinciaId",
                table: "Ciudades",
                column: "ProvinciaId",
                principalTable: "Provincias",
                principalColumn: "IdCiudad",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
