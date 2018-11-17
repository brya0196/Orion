using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.Data.Migrations
{
    public partial class ChangeCotnraseñaToPassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Contraseña",
                table: "Usuarios",
                newName: "Password");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Usuarios",
                newName: "Contraseña");
        }
    }
}
