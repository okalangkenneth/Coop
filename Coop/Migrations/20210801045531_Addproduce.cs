using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Coop.Migrations
{
    public partial class Addproduce : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProduceName_ProduceType_ProduceTypeId",
                table: "ProduceName");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProduceType",
                table: "ProduceType");

            migrationBuilder.RenameTable(
                name: "ProduceType",
                newName: "ProduceTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProduceTypes",
                table: "ProduceTypes",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produce",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProduceNameId = table.Column<int>(type: "int", nullable: false),
                    IsRegistered = table.Column<bool>(type: "bit", nullable: false),
                    ContactName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ContactEmail = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ContactPhone = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produce", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produce_ProduceName_ProduceNameId",
                        column: x => x.ProduceNameId,
                        principalTable: "ProduceName",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ProduceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photo_Produce_ProduceId",
                        column: x => x.ProduceId,
                        principalTable: "Produce",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProduceFeatures",
                columns: table => new
                {
                    ProduceId = table.Column<int>(type: "int", nullable: false),
                    FeatureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProduceFeatures", x => new { x.ProduceId, x.FeatureId });
                    table.ForeignKey(
                        name: "FK_ProduceFeatures_Features_FeatureId",
                        column: x => x.FeatureId,
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProduceFeatures_Produce_ProduceId",
                        column: x => x.ProduceId,
                        principalTable: "Produce",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Photo_ProduceId",
                table: "Photo",
                column: "ProduceId");

            migrationBuilder.CreateIndex(
                name: "IX_Produce_ProduceNameId",
                table: "Produce",
                column: "ProduceNameId");

            migrationBuilder.CreateIndex(
                name: "IX_ProduceFeatures_FeatureId",
                table: "ProduceFeatures",
                column: "FeatureId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProduceName_ProduceTypes_ProduceTypeId",
                table: "ProduceName",
                column: "ProduceTypeId",
                principalTable: "ProduceTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProduceName_ProduceTypes_ProduceTypeId",
                table: "ProduceName");

            migrationBuilder.DropTable(
                name: "Photo");

            migrationBuilder.DropTable(
                name: "ProduceFeatures");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "Produce");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProduceTypes",
                table: "ProduceTypes");

            migrationBuilder.RenameTable(
                name: "ProduceTypes",
                newName: "ProduceType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProduceType",
                table: "ProduceType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProduceName_ProduceType_ProduceTypeId",
                table: "ProduceName",
                column: "ProduceTypeId",
                principalTable: "ProduceType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
