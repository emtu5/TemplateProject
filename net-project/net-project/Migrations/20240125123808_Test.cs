using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace net_project.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.CreateTable(
                name: "Materii",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Denumire = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotaTrecere = table.Column<double>(type: "float", nullable: false),
                    OreSaptamana = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materii", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Profesori",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rol = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesori", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Relatii",
                columns: table => new
                {
                    ProfesorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfesorId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaterieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relatii", x => x.ProfesorId);
                    table.ForeignKey(
                        name: "FK_Relatii_Materii_MaterieId",
                        column: x => x.MaterieId,
                        principalTable: "Materii",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Relatii_Profesori_ProfesorId1",
                        column: x => x.ProfesorId1,
                        principalTable: "Profesori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Relatii_MaterieId",
                table: "Relatii",
                column: "MaterieId");

            migrationBuilder.CreateIndex(
                name: "IX_Relatii_ProfesorId1",
                table: "Relatii",
                column: "ProfesorId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Relatii");

            migrationBuilder.DropTable(
                name: "Materii");

            migrationBuilder.DropTable(
                name: "Profesori");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Highscore = table.Column<int>(type: "int", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Medals = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }
    }
}
