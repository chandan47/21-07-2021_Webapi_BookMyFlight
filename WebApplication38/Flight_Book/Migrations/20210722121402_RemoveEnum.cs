using Microsoft.EntityFrameworkCore.Migrations;

namespace Flight_Book.Migrations
{
    public partial class RemoveEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookFlightDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    emailID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noOfSeatsToBook = table.Column<int>(type: "int", nullable: false),
                    mealType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seatNumber = table.Column<int>(type: "int", nullable: false),
                    discountcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    triptype = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fromPlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    toPlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    startdatetime = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookFlightDetails", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookFlightDetails");
        }
    }
}
