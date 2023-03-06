using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class pre_convention : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "myplaness",
                columns: table => new
                {
                    PlaneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaneCapacity = table.Column<int>(type: "int", nullable: false),
                    ManufactureDate = table.Column<DateTime>(type: "date", nullable: false),
                    Planetype = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_myplaness", x => x.PlaneId);
                });

            migrationBuilder.CreateTable(
                name: "Passengers",
                columns: table => new
                {
                    PassportNumber = table.Column<int>(type: "int", maxLength: 7, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PassengerId = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: false),
                    EmailAdress = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    TelNumber = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    PassFirstName = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    PassLastName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    EmployementDate = table.Column<DateTime>(type: "date", nullable: true),
                    function = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Salary = table.Column<int>(type: "int", nullable: true),
                    healthInformation = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Nationality = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passengers", x => x.PassportNumber);
                });

            migrationBuilder.CreateTable(
                name: "vols ",
                columns: table => new
                {
                    FlightId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Destination = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Departure = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    FightDate = table.Column<DateTime>(type: "date", nullable: false),
                    EffectiveArrival = table.Column<DateTime>(type: "date", nullable: false),
                    EstimatedDuration = table.Column<int>(type: "int", nullable: false),
                    PlaneId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vols ", x => x.FlightId);
                    table.ForeignKey(
                        name: "FK_vols _myplaness_PlaneId",
                        column: x => x.PlaneId,
                        principalTable: "myplaness",
                        principalColumn: "PlaneId",
                        onDelete: ReferentialAction.SetNull);
                });

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
                        name: "FK_myreservations_Passengers_PassengersPassportNumber",
                        column: x => x.PassengersPassportNumber,
                        principalTable: "Passengers",
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

            migrationBuilder.CreateIndex(
                name: "IX_vols _PlaneId",
                table: "vols ",
                column: "PlaneId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "myreservations");

            migrationBuilder.DropTable(
                name: "Passengers");

            migrationBuilder.DropTable(
                name: "vols ");

            migrationBuilder.DropTable(
                name: "myplaness");
        }
    }
}
