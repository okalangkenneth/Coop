using Microsoft.EntityFrameworkCore.Migrations;

namespace Coop.Migrations
{
    public partial class InitialModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProduceType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProduceType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProduceName",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ProduceTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProduceName", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProduceName_ProduceType_ProduceTypeId",
                        column: x => x.ProduceTypeId,
                        principalTable: "ProduceType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProduceName_ProduceTypeId",
                table: "ProduceName",
                column: "ProduceTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProduceName");

            migrationBuilder.DropTable(
                name: "ProduceType");
        }
    }
}
