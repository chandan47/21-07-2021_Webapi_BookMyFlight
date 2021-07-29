using Microsoft.EntityFrameworkCore.Migrations;

namespace Flight_Book.Migrations
{
    public partial class TotalPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "totalPrice",
                table: "BookFlightDetails",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "totalPrice",
                table: "BookFlightDetails");
        }
    }
}
