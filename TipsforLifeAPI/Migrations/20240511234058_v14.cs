using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TipsforLifeAPI.Migrations
{
    /// <inheritdoc />
    public partial class v14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Mensagem",
                table: "Slip",
                newName: "Advice");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Advice",
                table: "Slip",
                newName: "Mensagem");
        }
    }
}
