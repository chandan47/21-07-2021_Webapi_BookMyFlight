using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication38.Migrations
{
    public partial class AirlineDeatils : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AirlineDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    airlineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    uploadLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fromPlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    toPlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    startdatetime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    enddatetime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    scheduleddays = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    instrumentUsed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tNoBusinessClassSeats = table.Column<int>(type: "int", nullable: false),
                    tNoNonBusinessClassSeats = table.Column<int>(type: "int", nullable: false),
                    ticketCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    numberofRows = table.Column<int>(type: "int", nullable: false),
                    meal = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirlineDetails", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AirlineDetails");
        }
    }
}
