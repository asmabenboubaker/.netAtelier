using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class manytopmany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "myreservations");

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    PassengerFK = table.Column<int>(type: "int", nullable: false),
                    FlightFK = table.Column<int>(type: "int", nullable: false),
                    Prix = table.Column<double>(type: "float(3)", precision: 3, scale: 2, nullable: false),
                    Siege = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    VIP = table.Column<bool>(type: "bit", nullable: false),
                    FlightId = table.Column<int>(type: "int", nullable: false),
                    passengerPassportNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => new { x.FlightFK, x.PassengerFK });
                    table.ForeignKey(
                        name: "FK_Ticket_Passenger_passengerPassportNumber",
                        column: x => x.passengerPassportNumber,
                        principalTable: "Passenger",
                        principalColumn: "PassportNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ticket_vols _FlightId",
                        column: x => x.FlightId,
                        principalTable: "vols ",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_FlightId",
                table: "Ticket",
                column: "FlightId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_passengerPassportNumber",
                table: "Ticket",
                column: "passengerPassportNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.CreateTable(
                name: "myreservations",
                columns: table => new
                {
                    PassengersPassportNumber = table.Column<int>(type: "int", nullable: false),
                    flightsFlightId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_myreservations", x => new { x.PassengersPassportNumber, x.flightsFlightId });
                    table.ForeignKey(
                        name: "FK_myreservations_Passenger_PassengersPassportNumber",
                        column: x => x.PassengersPassportNumber,
                        principalTable: "Passenger",
                        principalColumn: "PassportNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_myreservations_vols _flightsFlightId",
                        column: x => x.flightsFlightId,
                        principalTable: "vols ",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_myreservations_flightsFlightId",
                table: "myreservations",
                column: "flightsFlightId");
        }
    }
}
