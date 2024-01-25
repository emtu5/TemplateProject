using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace net_project.Migrations
{
    /// <inheritdoc />
    public partial class Test3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Relatii_Materii_MaterieId",
                table: "Relatii");

            migrationBuilder.DropForeignKey(
                name: "FK_Relatii_Profesori_ProfesorId1",
                table: "Relatii");

            migrationBuilder.RenameColumn(
                name: "ProfesorId1",
                table: "Relatii",
                newName: "MaterieId1");

            migrationBuilder.RenameIndex(
                name: "IX_Relatii_ProfesorId1",
                table: "Relatii",
                newName: "IX_Relatii_MaterieId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Relatii_Materii_MaterieId1",
                table: "Relatii",
                column: "MaterieId1",
                principalTable: "Materii",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Relatii_Profesori_MaterieId",
                table: "Relatii",
                column: "MaterieId",
                principalTable: "Profesori",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Relatii_Materii_MaterieId1",
                table: "Relatii");

            migrationBuilder.DropForeignKey(
                name: "FK_Relatii_Profesori_MaterieId",
                table: "Relatii");

            migrationBuilder.RenameColumn(
                name: "MaterieId1",
                table: "Relatii",
                newName: "ProfesorId1");

            migrationBuilder.RenameIndex(
                name: "IX_Relatii_MaterieId1",
                table: "Relatii",
                newName: "IX_Relatii_ProfesorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Relatii_Materii_MaterieId",
                table: "Relatii",
                column: "MaterieId",
                principalTable: "Materii",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Relatii_Profesori_ProfesorId1",
                table: "Relatii",
                column: "ProfesorId1",
                principalTable: "Profesori",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
