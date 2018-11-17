using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.Data.Migrations
{
    public partial class ChangeTheForeignKeysOnUsuarios5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdTipoUsuario",
                table: "Usuarios");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdTipoUsuario",
                table: "Usuarios",
                nullable: true);
        }
    }
}
