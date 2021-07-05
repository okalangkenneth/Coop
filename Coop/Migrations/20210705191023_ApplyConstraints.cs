using Microsoft.EntityFrameworkCore.Migrations;

namespace Coop.Migrations
{
    public partial class ApplyConstraints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProduceName_produceTypes_ProduceTypeId",
                table: "ProduceName");

            migrationBuilder.DropPrimaryKey(
                name: "PK_produceTypes",
                table: "produceTypes");

            migrationBuilder.RenameTable(
                name: "produceTypes",
                newName: "ProduceTypes");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ProduceTypes",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ProduceName",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProduceTypes",
                table: "ProduceTypes",
                column: "Id");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProduceTypes",
                table: "ProduceTypes");

            migrationBuilder.RenameTable(
                name: "ProduceTypes",
                newName: "produceTypes");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "produceTypes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ProduceName",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AddPrimaryKey(
                name: "PK_produceTypes",
                table: "produceTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProduceName_produceTypes_ProduceTypeId",
                table: "ProduceName",
                column: "ProduceTypeId",
                principalTable: "produceTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
