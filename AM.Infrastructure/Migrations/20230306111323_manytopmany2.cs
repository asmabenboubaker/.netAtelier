using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class manytopmany2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Passenger_passengerPassportNumber",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_vols _FlightId",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_FlightId",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_passengerPassportNumber",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "FlightId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "passengerPassportNumber",
                table: "Ticket");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_PassengerFK",
                table: "Ticket",
                column: "PassengerFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Passenger_PassengerFK",
                table: "Ticket",
                column: "PassengerFK",
                principalTable: "Passenger",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_vols _FlightFK",
                table: "Ticket",
                column: "FlightFK",
                principalTable: "vols ",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Passenger_PassengerFK",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_vols _FlightFK",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_PassengerFK",
                table: "Ticket");

            migrationBuilder.AddColumn<int>(
                name: "FlightId",
                table: "Ticket",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "passengerPassportNumber",
                table: "Ticket",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_FlightId",
                table: "Ticket",
                column: "FlightId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_passengerPassportNumber",
                table: "Ticket",
                column: "passengerPassportNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Passenger_passengerPassportNumber",
                table: "Ticket",
                column: "passengerPassportNumber",
                principalTable: "Passenger",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_vols _FlightId",
                table: "Ticket",
                column: "FlightId",
                principalTable: "vols ",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
