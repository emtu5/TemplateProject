using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace net_project.Migrations
{
    /// <inheritdoc />
    public partial class Test4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Relatii",
                table: "Relatii");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Relatii",
                table: "Relatii",
                columns: new[] { "ProfesorId", "MaterieId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Relatii",
                table: "Relatii");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Relatii",
                table: "Relatii",
                column: "ProfesorId");
        }
    }
}
