using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication38.Migrations
{
    public partial class AlterTable_FlightNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "flightNumber",
                table: "AirlineDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "isBlocked",
                table: "AirlineDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "status",
                table: "AirlineDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "flightNumber",
                table: "AirlineDetails");

            migrationBuilder.DropColumn(
                name: "isBlocked",
                table: "AirlineDetails");

            migrationBuilder.DropColumn(
                name: "status",
                table: "AirlineDetails");
        }
    }
}
