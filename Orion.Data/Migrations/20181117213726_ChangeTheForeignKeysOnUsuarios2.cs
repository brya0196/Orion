using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.Data.Migrations
{
    public partial class ChangeTheForeignKeysOnUsuarios2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_TiposUsuarios_TiposUsuarioId",
                table: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "TiposUsuarioId",
                table: "Usuarios",
                newName: "TipoUsuarioIdId");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_TiposUsuarioId",
                table: "Usuarios",
                newName: "IX_Usuarios_TipoUsuarioIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_TiposUsuarios_TipoUsuarioIdId",
                table: "Usuarios",
                column: "TipoUsuarioIdId",
                principalTable: "TiposUsuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_TiposUsuarios_TipoUsuarioIdId",
                table: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "TipoUsuarioIdId",
                table: "Usuarios",
                newName: "TiposUsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_TipoUsuarioIdId",
                table: "Usuarios",
                newName: "IX_Usuarios_TiposUsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_TiposUsuarios_TiposUsuarioId",
                table: "Usuarios",
                column: "TiposUsuarioId",
                principalTable: "TiposUsuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
