using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.Data.Migrations
{
    public partial class ChangeTheForeignKeysOnUsuarios3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_TiposUsuarios_TipoUsuarioIdId",
                table: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "TipoUsuarioIdId",
                table: "Usuarios",
                newName: "TipoUsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_TipoUsuarioIdId",
                table: "Usuarios",
                newName: "IX_Usuarios_TipoUsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_TiposUsuarios_TipoUsuarioId",
                table: "Usuarios",
                column: "TipoUsuarioId",
                principalTable: "TiposUsuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_TiposUsuarios_TipoUsuarioId",
                table: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "TipoUsuarioId",
                table: "Usuarios",
                newName: "TipoUsuarioIdId");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_TipoUsuarioId",
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
    }
}
