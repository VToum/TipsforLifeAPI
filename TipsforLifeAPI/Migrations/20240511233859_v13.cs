using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TipsforLifeAPI.Migrations
{
    /// <inheritdoc />
    public partial class v13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Slip",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Mensagem = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slip", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "dicas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SlipId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dicas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dicas_Slip_SlipId",
                        column: x => x.SlipId,
                        principalTable: "Slip",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_dicas_SlipId",
                table: "dicas",
                column: "SlipId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dicas");

            migrationBuilder.DropTable(
                name: "Slip");
        }
    }
}
