using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.Data.Migrations
{
    public partial class ChangeTheForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_TiposUsuarios_TipoUsuarioId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_TipoUsuarioId",
                table: "Usuarios");

            migrationBuilder.AlterColumn<int>(
                name: "TipoUsuarioId",
                table: "Usuarios",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TiposUsuarioId",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_TiposUsuarioId",
                table: "Usuarios",
                column: "TiposUsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_TiposUsuarios_TiposUsuarioId",
                table: "Usuarios",
                column: "TiposUsuarioId",
                principalTable: "TiposUsuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_TiposUsuarios_TiposUsuarioId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_TiposUsuarioId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "TiposUsuarioId",
                table: "Usuarios");

            migrationBuilder.AlterColumn<int>(
                name: "TipoUsuarioId",
                table: "Usuarios",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_TipoUsuarioId",
                table: "Usuarios",
                column: "TipoUsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_TiposUsuarios_TipoUsuarioId",
                table: "Usuarios",
                column: "TipoUsuarioId",
                principalTable: "TiposUsuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
