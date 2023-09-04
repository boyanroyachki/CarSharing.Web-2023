using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarSharing.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedProps : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("6c0a4ae0-837f-415d-90a1-53ffb2e2142c"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("cf3fd55a-d3b9-42dd-9edb-7856e4caf7f9"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Vehicles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsRented",
                table: "Vehicles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "AgentId", "AppUserId", "CategoryId", "Description", "FuelType", "IsDeleted", "IsRented", "Make", "Model", "ModelYear", "NoteFromOwner", "PlateNumber", "PricePerHour" },
                values: new object[,]
                {
                    { new Guid("0957b2bf-e77b-4f9c-9bcc-b37b495e9619"), new Guid("41d679fe-6b8c-4818-a6df-f99067dfcbf7"), null, 1, "The bigger brother of the F150, the Ford Raptor!", "Disel", false, false, "Ford", "Ramptor", "2019", "Take care of the paint job!", "CB1238CC", 0m },
                    { new Guid("7e0b3f4d-5965-4dea-9176-1711043b5865"), new Guid("41d679fe-6b8c-4818-a6df-f99067dfcbf7"), null, 1, "Very nice, old Ford Ranger! Proven trough the years.", "Disel", false, false, "Ford", "Ranger", "2004", "Possible to hear strange noises!", "CB1234MA", 0m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("0957b2bf-e77b-4f9c-9bcc-b37b495e9619"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("7e0b3f4d-5965-4dea-9176-1711043b5865"));

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "IsRented",
                table: "Vehicles");

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "AgentId", "AppUserId", "CategoryId", "Description", "FuelType", "Make", "Model", "ModelYear", "NoteFromOwner", "PlateNumber", "PricePerHour" },
                values: new object[,]
                {
                    { new Guid("6c0a4ae0-837f-415d-90a1-53ffb2e2142c"), new Guid("41d679fe-6b8c-4818-a6df-f99067dfcbf7"), null, 1, "Very nice, old Ford Ranger! Proven trough the years.", "Disel", "Ford", "Ranger", "2004", "Possible to hear strange noises!", "CB1234MA", 0m },
                    { new Guid("cf3fd55a-d3b9-42dd-9edb-7856e4caf7f9"), new Guid("41d679fe-6b8c-4818-a6df-f99067dfcbf7"), null, 1, "The bigger brother of the F150, the Ford Raptor!", "Disel", "Ford", "Ramptor", "2019", "Take care of the paint job!", "CB1238CC", 0m }
                });
        }
    }
}
