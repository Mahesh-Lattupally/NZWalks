using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NZWalks.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataforDifficultiesandRegions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("18a21bc0-9507-4665-8286-a218a8f79320"), "Hard" },
                    { new Guid("4c1c803b-205b-4da1-98fb-d3ece044b7f5"), "Easy" },
                    { new Guid("ad00f16c-69e9-41f6-bc1e-924d2dbbe52a"), "Medium" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("14bb6474-98af-4af9-82f3-b0f0ea032151"), "Northland", "NTL", "https://images.app.goo.gl/o4ATMn4Dotz5AH7n8" },
                    { new Guid("1fa662ba-fec9-4688-a791-a51abfe46636"), "CC", "Christchurch", "https://images.app.goo.gl/9UjWkwGkQTfSSoj18" },
                    { new Guid("22595f86-fcc7-48db-a8a4-4c71e1d71a1c"), "STL", "Southland", "https://images.app.goo.gl/Jy7TLKwa5wgQtUneA" },
                    { new Guid("45d29a9c-3faa-47c1-8be4-2e0d6e4e0e34"), "AKL", "Auckland", "https://images.app.goo.gl/2cGwTsEPehnAJMLp7" },
                    { new Guid("7cebc750-6f2c-4e49-ab04-f9d07303cc7d"), "WLG", "Wellingtown", "https://images.app.goo.gl/SbyGgmxzdswDkMPe6" },
                    { new Guid("854434c7-eebc-42ae-b045-57a583cd7e10"), "BOP", "Bay Of Plenty", "https://images.app.goo.gl/mGiWkWDenNQ8eHEH6" },
                    { new Guid("edf6f527-0338-4cce-a920-13cc51e8fc8d"), "Nelson", "NSN", "https://images.app.goo.gl/9F8Ki6uD6swa1EJR7" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("18a21bc0-9507-4665-8286-a218a8f79320"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("4c1c803b-205b-4da1-98fb-d3ece044b7f5"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("ad00f16c-69e9-41f6-bc1e-924d2dbbe52a"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("14bb6474-98af-4af9-82f3-b0f0ea032151"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("1fa662ba-fec9-4688-a791-a51abfe46636"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("22595f86-fcc7-48db-a8a4-4c71e1d71a1c"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("45d29a9c-3faa-47c1-8be4-2e0d6e4e0e34"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("7cebc750-6f2c-4e49-ab04-f9d07303cc7d"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("854434c7-eebc-42ae-b045-57a583cd7e10"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("edf6f527-0338-4cce-a920-13cc51e8fc8d"));
        }
    }
}
