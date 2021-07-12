using Microsoft.EntityFrameworkCore.Migrations;

namespace Coop.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO ProduceTypes (Name) VALUES ('ProduceType1')");
            migrationBuilder.Sql("INSERT INTO ProduceTypes (Name) VALUES ('ProduceType2')");
            migrationBuilder.Sql("INSERT INTO ProduceTypes (Name) VALUES ('ProduceType3')");

            migrationBuilder.Sql("INSERT INTO ProduceNames (Name,ProduceTypeID) VALUES ('ProduceType1-ProduceNameA',(SELECT ID FROM ProduceTypes WHERE Name = 'ProduceType1'))");
            migrationBuilder.Sql("INSERT INTO ProduceNames (Name,ProduceTypeID) VALUES ('ProduceType1-ProduceNameB',(SELECT ID FROM ProduceTypes WHERE Name = 'ProduceType1'))");
            migrationBuilder.Sql("INSERT INTO ProduceNames (Name,ProduceTypeID) VALUES ('ProduceType1-ProduceNameC',(SELECT ID FROM ProduceTypes WHERE Name = 'ProduceType1'))");

            migrationBuilder.Sql("INSERT INTO ProduceNames (Name,ProduceTypeID) VALUES ('ProduceType2-ProduceNameA',(SELECT ID FROM ProduceTypes WHERE Name = 'ProduceType2'))");
            migrationBuilder.Sql("INSERT INTO ProduceNames (Name,ProduceTypeID) VALUES ('ProduceType2-ProduceNameB',(SELECT ID FROM ProduceTypes WHERE Name = 'ProduceType2'))");
            migrationBuilder.Sql("INSERT INTO ProduceNames (Name,ProduceTypeID) VALUES ('ProduceType2-ProduceNameC',(SELECT ID FROM ProduceTypes WHERE Name = 'ProduceType2'))");

            migrationBuilder.Sql("INSERT INTO ProduceNames (Name,ProduceTypeID) VALUES ('ProduceType3-ProduceNameA',(SELECT ID FROM ProduceTypes WHERE Name = 'ProduceType3'))");
            migrationBuilder.Sql("INSERT INTO ProduceNames (Name,ProduceTypeID) VALUES ('ProduceType3-ProduceNameB',(SELECT ID FROM ProduceTypes WHERE Name = 'ProduceType3'))");
            migrationBuilder.Sql("INSERT INTO ProduceNames (Name,ProduceTypeID) VALUES ('ProduceType3-ProduceNameC',(SELECT ID FROM ProduceTypes WHERE Name = 'ProduceType3'))");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM ProduceTypes WHERE Name IN ('ProduceType1','ProduceType2','ProduceType3')");
        }
    }
}
