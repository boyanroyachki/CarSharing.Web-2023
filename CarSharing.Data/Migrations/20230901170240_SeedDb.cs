using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarSharing.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "kurec", "Trucks" },
                    { 2, "kurec", "Sport cars" },
                    { 3, "kurec", "Economy" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "AgentId", "AppUserId", "CategoryId", "Description", "FuelType", "Make", "Model", "ModelYear", "NoteFromOwner", "PlateNumber", "PricePerHour" },
                values: new object[,]
                {
                    { new Guid("6c0a4ae0-837f-415d-90a1-53ffb2e2142c"), new Guid("41d679fe-6b8c-4818-a6df-f99067dfcbf7"), null, 1, "Very nice, old Ford Ranger! Proven trough the years.", "Disel", "Ford", "Ranger", "2004", "Possible to hear strange noises!", "CB1234MA", 0m },
                    { new Guid("cf3fd55a-d3b9-42dd-9edb-7856e4caf7f9"), new Guid("41d679fe-6b8c-4818-a6df-f99067dfcbf7"), null, 1, "The bigger brother of the F150, the Ford Raptor!", "Disel", "Ford", "Ramptor", "2019", "Take care of the paint job!", "CB1238CC", 0m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("6c0a4ae0-837f-415d-90a1-53ffb2e2142c"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("cf3fd55a-d3b9-42dd-9edb-7856e4caf7f9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
