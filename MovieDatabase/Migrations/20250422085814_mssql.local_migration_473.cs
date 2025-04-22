using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieDatabase.Migrations
{
    /// <inheritdoc />
    public partial class mssqllocal_migration_473 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RealeseDate",
                table: "Movie",
                newName: "ReleaseDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReleaseDate",
                table: "Movie",
                newName: "RealeseDate");
        }
    }
}
