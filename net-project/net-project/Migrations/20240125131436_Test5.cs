using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace net_project.Migrations
{
    /// <inheritdoc />
    public partial class Test5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Relatii_Materii_MaterieId1",
                table: "Relatii");

            migrationBuilder.DropForeignKey(
                name: "FK_Relatii_Profesori_MaterieId",
                table: "Relatii");

            migrationBuilder.DropIndex(
                name: "IX_Relatii_MaterieId1",
                table: "Relatii");

            migrationBuilder.DropColumn(
                name: "MaterieId1",
                table: "Relatii");

            migrationBuilder.AddForeignKey(
                name: "FK_Relatii_Materii_MaterieId",
                table: "Relatii",
                column: "MaterieId",
                principalTable: "Materii",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Relatii_Profesori_ProfesorId",
                table: "Relatii",
                column: "ProfesorId",
                principalTable: "Profesori",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Relatii_Materii_MaterieId",
                table: "Relatii");

            migrationBuilder.DropForeignKey(
                name: "FK_Relatii_Profesori_ProfesorId",
                table: "Relatii");

            migrationBuilder.AddColumn<Guid>(
                name: "MaterieId1",
                table: "Relatii",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Relatii_MaterieId1",
                table: "Relatii",
                column: "MaterieId1");

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
    }
}
