using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcPlants.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Plant",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Family = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Genus = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Species = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Origin = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plant", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Plant");
        }
    }
}
