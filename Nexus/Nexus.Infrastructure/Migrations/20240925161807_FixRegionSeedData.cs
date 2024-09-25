using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nexus.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixRegionSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.UpdateData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 1.0, 7.0, 4 });

            migrationBuilder.UpdateData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 2.0, 7.0, 4 });

            migrationBuilder.InsertData(
                table: "AsteroidField",
                columns: new[] { "Id", "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[,]
                {
                    { 6, 1.0, 6.0, 1 },
                    { 7, 2.0, 4.0, 1 },
                    { 14, 4.0, 2.0, 2 },
                    { 15, 2.0, 6.0, 2 },
                    { 23, 3.0, 5.0, 3 },
                    { 24, 7.0, 8.0, 3 },
                    { 30, 1.0, 5.0, 4 },
                    { 34, 6.0, 7.0, 5 },
                    { 35, 7.0, 6.0, 5 },
                    { 42, 5.0, 9.0, 6 },
                    { 43, 3.0, 2.0, 6 },
                    { 50, 2.0, 11.0, 7 },
                    { 51, 3.0, 11.0, 7 },
                    { 68, 5.0, 2.0, 9 },
                    { 77, 1.0, 6.0, 10 },
                    { 78, 7.0, 4.0, 10 }
                });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 4.0, 5.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 2,
                column: "CoordinateY",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 7.0, 7.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 4,
                column: "CoordinateX",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 4.0, 5.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 9.0, 4.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 9.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 5.0, 8.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 9.0, 9.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 10,
                column: "CoordinateX",
                value: 10.0);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 2.0, 9.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 7.0, 8.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CoordinateX",
                value: 6.0);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 4.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 8,
                column: "CoordinateX",
                value: 7.0);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 8.0, 11.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 5.0, 11.0, 2 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 9.0, 8.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 8.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 1.0, 3.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 19,
                column: "CoordinateY",
                value: 6.0);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 7.0, 5.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 5.0, 8.0, 3 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 1.0, 9.0, 3 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 7.0, 6.0, 4 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 1.0, 2.0, 4 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 6.0, 2.0, 4 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 3.0, 2.0, 5 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 2.0, 6.0, 5 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 5.0, 1.0, 5 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CoordinateX", "SolarSystemId" },
                values: new object[] { 7.0, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 3.0, 6.0, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 2.0, 8.0, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 11.0, 6.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 2.0, 5.0, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 8.0, 7.0, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 52,
                column: "CoordinateX",
                value: 6.0);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 9.0, 4.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 6.0, 11.0, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 9.0, 11.0, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 9.0, 1.0, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 3.0, 1.0, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 7.0, 7.0, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 7.0, 4.0, 9 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 1.0, 6.0, 9 });

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "Id", "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[,]
                {
                    { 10, 10.0, 4.0, 2 },
                    { 11, 1.0, 11.0, 2 },
                    { 12, 2.0, 9.0, 2 },
                    { 36, 7.0, 9.0, 6 },
                    { 37, 8.0, 1.0, 6 },
                    { 38, 5.0, 6.0, 6 },
                    { 45, 4.0, 1.0, 7 },
                    { 46, 10.0, 11.0, 7 },
                    { 47, 6.0, 5.0, 7 },
                    { 54, 7.0, 3.0, 8 },
                    { 55, 3.0, 5.0, 8 },
                    { 61, 3.0, 9.0, 9 },
                    { 62, 3.0, 1.0, 9 },
                    { 65, 11.0, 11.0, 9 },
                    { 66, 11.0, 2.0, 9 },
                    { 67, 8.0, 1.0, 9 },
                    { 69, 3.0, 3.0, 10 },
                    { 70, 10.0, 11.0, 10 },
                    { 71, 4.0, 9.0, 10 },
                    { 72, 8.0, 6.0, 10 },
                    { 73, 2.0, 8.0, 10 },
                    { 74, 6.0, 6.0, 10 },
                    { 75, 4.0, 1.0, 10 },
                    { 76, 11.0, 1.0, 10 }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "GovernorCardId", "IsColonized", "PlanetId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, null, false, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, null, false, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, null, false, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, null, false, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, null, false, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, null, false, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, null, false, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, null, false, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, null, false, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, null, false, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11, null, false, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, null, false, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, null, false, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, null, false, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, null, false, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16, null, false, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17, null, false, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18, null, false, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19, null, false, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20, null, false, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 21, null, false, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 31, null, false, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 32, null, false, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 33, null, false, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 34, null, false, 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 35, null, false, 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 36, null, false, 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 37, null, false, 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 38, null, false, 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 39, null, false, 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 40, null, false, 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 41, null, false, 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 42, null, false, 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 43, null, false, 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 44, null, false, 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 45, null, false, 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 46, null, false, 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 47, null, false, 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 48, null, false, 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 49, null, false, 21, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 50, null, false, 21, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 51, null, false, 21, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 52, null, false, 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 53, null, false, 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 54, null, false, 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 55, null, false, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 56, null, false, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 57, null, false, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 58, null, false, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 59, null, false, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 60, null, false, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 61, null, false, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 62, null, false, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 63, null, false, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 64, null, false, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 65, null, false, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 66, null, false, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 67, null, false, 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 68, null, false, 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 69, null, false, 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 70, null, false, 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 71, null, false, 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 72, null, false, 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 82, null, false, 39, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 83, null, false, 39, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 84, null, false, 39, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 85, null, false, 40, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 86, null, false, 40, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 87, null, false, 40, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 88, null, false, 41, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 89, null, false, 41, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 90, null, false, 41, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 91, null, false, 44, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 92, null, false, 44, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 93, null, false, 44, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 103, null, false, 48, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 104, null, false, 48, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 105, null, false, 48, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 106, null, false, 49, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 107, null, false, 49, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 108, null, false, 49, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 109, null, false, 52, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 110, null, false, 52, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 111, null, false, 52, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 112, null, false, 53, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 113, null, false, 53, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 114, null, false, 53, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 121, null, false, 56, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 122, null, false, 56, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 123, null, false, 56, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 124, null, false, 57, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 125, null, false, 57, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 126, null, false, 57, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 127, null, false, 58, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 128, null, false, 58, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 129, null, false, 58, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 130, null, false, 59, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 131, null, false, 59, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 132, null, false, 59, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 133, null, false, 60, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 134, null, false, 60, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 135, null, false, 60, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 142, null, false, 63, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 143, null, false, 63, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 144, null, false, 63, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 145, null, false, 64, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 146, null, false, 64, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 147, null, false, 64, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.UpdateData(
                table: "SolarSystems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "GridSizeX", "GridSizeY" },
                values: new object[] { 7, 7 });

            migrationBuilder.UpdateData(
                table: "SolarSystems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "GridSizeX", "GridSizeY" },
                values: new object[] { 7, 7 });

            migrationBuilder.UpdateData(
                table: "SolarSystems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "GridSizeX", "GridSizeY" },
                values: new object[] { 7, 7 });

            migrationBuilder.UpdateData(
                table: "SolarSystems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "GridSizeX", "GridSizeY" },
                values: new object[] { 7, 7 });

            migrationBuilder.UpdateData(
                table: "SolarSystems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "GridSizeX", "GridSizeY" },
                values: new object[] { 7, 7 });

            migrationBuilder.UpdateData(
                table: "SolarSystems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "GridSizeX", "GridSizeY" },
                values: new object[] { 7, 7 });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "GovernorCardId", "IsColonized", "PlanetId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 22, null, false, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 23, null, false, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 24, null, false, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 25, null, false, 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 26, null, false, 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 27, null, false, 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 28, null, false, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 29, null, false, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 30, null, false, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 73, null, false, 36, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 74, null, false, 36, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 75, null, false, 36, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 76, null, false, 37, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 77, null, false, 37, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 78, null, false, 37, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 79, null, false, 38, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 80, null, false, 38, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 81, null, false, 38, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 94, null, false, 45, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 95, null, false, 45, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 96, null, false, 45, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 97, null, false, 46, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 98, null, false, 46, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 99, null, false, 46, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 100, null, false, 47, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 101, null, false, 47, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 102, null, false, 47, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 115, null, false, 54, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 116, null, false, 54, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 117, null, false, 54, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 118, null, false, 55, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 119, null, false, 55, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 120, null, false, 55, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 136, null, false, 61, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 137, null, false, 61, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 138, null, false, 61, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 139, null, false, 62, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 140, null, false, 62, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 141, null, false, 62, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 148, null, false, 65, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 149, null, false, 65, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 150, null, false, 65, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 151, null, false, 66, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 152, null, false, 66, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 153, null, false, 66, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 154, null, false, 67, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 155, null, false, 67, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 156, null, false, 67, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 157, null, false, 69, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 158, null, false, 69, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 159, null, false, 69, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 160, null, false, 70, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 161, null, false, 70, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 162, null, false, 70, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 163, null, false, 71, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 164, null, false, 71, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 165, null, false, 71, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 166, null, false, 72, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 167, null, false, 72, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 168, null, false, 72, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 169, null, false, 73, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 170, null, false, 73, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 171, null, false, 73, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 172, null, false, 74, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 173, null, false, 74, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 174, null, false, 74, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 175, null, false, 75, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 176, null, false, 75, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 177, null, false, 75, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 178, null, false, 76, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 179, null, false, 76, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 180, null, false, 76, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.UpdateData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 4.0, 1.0, 5 });

            migrationBuilder.UpdateData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 4.0, 3.0, 5 });

            migrationBuilder.InsertData(
                table: "AsteroidField",
                columns: new[] { "Id", "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[,]
                {
                    { 10, 1.0, 2.0, 2 },
                    { 11, 3.0, 2.0, 2 },
                    { 12, 4.0, 7.0, 2 },
                    { 36, 1.0, 6.0, 6 },
                    { 37, 10.0, 8.0, 6 },
                    { 38, 3.0, 5.0, 6 },
                    { 45, 6.0, 11.0, 7 },
                    { 46, 10.0, 9.0, 7 },
                    { 47, 5.0, 10.0, 7 },
                    { 54, 5.0, 2.0, 8 },
                    { 55, 2.0, 6.0, 8 },
                    { 61, 4.0, 2.0, 9 },
                    { 62, 1.0, 6.0, 9 },
                    { 65, 6.0, 3.0, 10 }
                });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 8.0, 8.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 2,
                column: "CoordinateY",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 5.0, 4.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 4,
                column: "CoordinateX",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 2.0, 7.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 11.0, 3.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 10.0, 10.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 6.0, 3.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 5.0, 3.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 10,
                column: "CoordinateX",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 5.0, 3.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 3.0, 4.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 7.0, 6.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CoordinateX",
                value: 8.0);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 6.0, 9.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 8,
                column: "CoordinateX",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 7.0, 5.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 2.0, 5.0, 3 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 11.0, 2.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 6.0, 10.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 6.0, 6.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 19,
                column: "CoordinateY",
                value: 11.0);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 2.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 3.0, 9.0, 4 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 8.0, 4.0, 4 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 4.0, 5.0, 5 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 7.0, 3.0, 5 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 7.0, 6.0, 5 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 2.0, 8.0, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 10.0, 1.0, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 7.0, 4.0, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CoordinateX", "SolarSystemId" },
                values: new object[] { 5.0, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 8.0, 11.0, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 9.0, 7.0, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 10.0, 2.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 1.0, 1.0, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 7.0, 5.0, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 52,
                column: "CoordinateX",
                value: 10.0);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 2.0, 11.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 7.0, 3.0, 9 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 6.0, 1.0, 9 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 5.0, 6.0, 9 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 1.0, 3.0, 9 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 3.0, 6.0, 9 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 4.0, 2.0, 10 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 2.0, 7.0, 10 });

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "Id", "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[,]
                {
                    { 6, 1.0, 3.0, 1 },
                    { 7, 1.0, 6.0, 1 },
                    { 14, 9.0, 7.0, 3 },
                    { 15, 6.0, 8.0, 3 },
                    { 23, 5.0, 5.0, 4 },
                    { 24, 3.0, 2.0, 4 },
                    { 30, 4.0, 1.0, 6 },
                    { 34, 8.0, 11.0, 6 },
                    { 35, 11.0, 10.0, 6 },
                    { 42, 7.0, 9.0, 7 },
                    { 43, 7.0, 1.0, 7 },
                    { 50, 3.0, 8.0, 8 },
                    { 51, 4.0, 10.0, 8 }
                });

            migrationBuilder.UpdateData(
                table: "SolarSystems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "GridSizeX", "GridSizeY" },
                values: new object[] { 9, 9 });

            migrationBuilder.UpdateData(
                table: "SolarSystems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "GridSizeX", "GridSizeY" },
                values: new object[] { 11, 11 });

            migrationBuilder.UpdateData(
                table: "SolarSystems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "GridSizeX", "GridSizeY" },
                values: new object[] { 9, 9 });

            migrationBuilder.UpdateData(
                table: "SolarSystems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "GridSizeX", "GridSizeY" },
                values: new object[] { 11, 11 });

            migrationBuilder.UpdateData(
                table: "SolarSystems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "GridSizeX", "GridSizeY" },
                values: new object[] { 11, 11 });

            migrationBuilder.UpdateData(
                table: "SolarSystems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "GridSizeX", "GridSizeY" },
                values: new object[] { 11, 11 });
        }
    }
}
