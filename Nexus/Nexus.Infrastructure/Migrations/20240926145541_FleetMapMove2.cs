using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nexus.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FleetMapMove2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fleets_SolarSystems_SolarSystemId1",
                table: "Fleets");

            migrationBuilder.DropIndex(
                name: "IX_Fleets_SolarSystemId1",
                table: "Fleets");

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 9);

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
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 53);

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
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 68);

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

            migrationBuilder.DropColumn(
                name: "SolarSystemId1",
                table: "Fleets");

            migrationBuilder.UpdateData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CoordinateX", "SolarSystemId" },
                values: new object[] { 5.0, 5 });

            migrationBuilder.InsertData(
                table: "AsteroidField",
                columns: new[] { "Id", "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[,]
                {
                    { 16, 3.0, 6.0, 3 },
                    { 17, 7.0, 8.0, 3 },
                    { 18, 9.0, 9.0, 3 },
                    { 24, 5.0, 7.0, 4 },
                    { 31, 8.0, 9.0, 5 },
                    { 38, 1.0, 1.0, 6 },
                    { 39, 4.0, 5.0, 6 },
                    { 40, 5.0, 3.0, 6 },
                    { 50, 5.0, 3.0, 8 },
                    { 51, 4.0, 3.0, 8 },
                    { 52, 2.0, 1.0, 8 },
                    { 56, 7.0, 7.0, 9 },
                    { 57, 6.0, 4.0, 9 },
                    { 67, 3.0, 11.0, 10 }
                });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 6.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 8.0, 5.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 2.0, 4.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 5.0, 8.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 5.0, 2.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 8.0, 7.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 7.0, 3.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 6.0, 4.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 1.0, 4.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CoordinateY",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 3.0, 6.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 9.0, 8.0, 2 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 2.0, 10.0, 2 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 7.0, 8.0, 2 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 1.0, 8.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 6.0, 11.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CoordinateX", "SolarSystemId" },
                values: new object[] { 8.0, 3 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CoordinateY", "SolarSystemId" },
                values: new object[] { 6.0, 3 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 7.0, 7.0, 4 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 3.0, 5.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 5.0, 3.0, 5 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 1.0, 2.0, 5 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 3.0, 7.0, 5 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 8.0, 1.0, 5 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 1.0, 6.0, 5 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 5.0, 7.0, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 3.0, 7.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 7.0, 3.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 3.0, 2.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 9.0, 3.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 7.0, 1.0, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 7.0, 9.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 4.0, 2.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 4.0, 9.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 1.0, 7.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 45,
                column: "CoordinateY",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 7.0, 3.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 2.0, 3.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 49,
                column: "CoordinateX",
                value: 6.0);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 10.0, 3.0, 10 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 3.0, 6.0, 10 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 3.0, 1.0, 10 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CoordinateX", "SolarSystemId" },
                values: new object[] { 9.0, 10 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 6.0, 2.0, 10 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 1.0, 8.0 });

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "Id", "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[,]
                {
                    { 7, 6.0, 1.0, 2 },
                    { 8, 1.0, 5.0, 2 },
                    { 9, 11.0, 3.0, 2 },
                    { 14, 2.0, 9.0, 3 },
                    { 15, 7.0, 5.0, 3 },
                    { 20, 4.0, 3.0, 4 },
                    { 21, 5.0, 5.0, 4 },
                    { 22, 1.0, 6.0, 4 },
                    { 46, 4.0, 5.0, 8 },
                    { 53, 4.0, 4.0, 9 },
                    { 54, 4.0, 1.0, 9 },
                    { 55, 2.0, 3.0, 9 },
                    { 63, 7.0, 9.0, 10 },
                    { 64, 10.0, 8.0, 10 },
                    { 65, 6.0, 6.0, 10 }
                });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 9,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 10,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 11,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7592));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 12,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7592));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 13,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 14,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 15,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7599));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 16,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7603));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 17,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 18,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7609) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7609) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7609) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7615) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7616) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7616) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7620) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7620) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7621) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7643) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7644) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7644) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7649) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7650) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7650) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7659) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7659) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7659) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 13, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7665) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 13, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7665) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 13, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7666) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 14, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 14, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 14, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 15, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7674) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 15, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7674) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 15, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7675) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 19, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 19, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 19, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7691) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 20, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7713) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 20, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7713) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 20, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7714) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 21, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7719) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 21, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 21, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 22, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7724) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 22, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7724) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 22, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7725) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 23, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7729) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 23, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 23, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 25, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 25, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 25, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 26, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7746) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 26, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7747) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 26, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7758) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 27, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7763) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 27, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7763) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 27, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7763) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 28, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7767) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 28, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7767) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 28, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7768) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 29, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 29, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 29, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 32, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7784) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 32, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7784) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 32, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7785) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 33, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7788) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 33, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7789) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 33, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7789) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 34, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7794) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 34, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7794) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 34, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7794) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 35, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 35, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 35, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7799) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 36, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7834) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 36, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7834) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 36, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7835) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 37, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7839) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 37, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 37, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 94,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 95,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 96,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 97,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 98,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 99,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 100,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 101,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 102,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 103,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 104,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 105,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 106,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 107,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 108,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7874));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 46, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7909) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 46, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7909) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 46, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7910) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 47, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7915) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 47, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7915) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 47, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7915) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 48, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7920) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 48, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7920) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 48, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 49, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7925) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 49, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7925) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 49, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7925) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 53, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7936) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 53, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7936) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 53, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7937) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 54, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7942) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 54, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7942) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 54, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7942) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 55, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7947) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 55, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7947) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 55, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7948) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 58, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7973) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 58, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7974) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 58, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7974) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 59, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7979) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 59, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7979) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 59, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7979) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 60, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7984) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 60, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7984) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 60, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7984) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 61, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7989) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 61, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7989) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 61, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7990) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 62, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7995) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 62, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7996) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 62, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(7996) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 63, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(8000) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 63, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(8000) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 63, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(8000) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 64, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(8004) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 64, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(8004) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 64, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(8005) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 65, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(8008) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 65, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(8009) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 65, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(8009) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 66, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(8013) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 66, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(8014) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 66, new DateTime(2024, 9, 26, 14, 55, 41, 339, DateTimeKind.Utc).AddTicks(8014) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 40);

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
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 9);

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
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 53);

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
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.AddColumn<int>(
                name: "SolarSystemId1",
                table: "Fleets",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CoordinateX", "SolarSystemId" },
                values: new object[] { 2.0, 4 });

            migrationBuilder.InsertData(
                table: "AsteroidField",
                columns: new[] { "Id", "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[,]
                {
                    { 7, 5.0, 2.0, 1 },
                    { 8, 7.0, 3.0, 1 },
                    { 9, 2.0, 3.0, 1 },
                    { 14, 5.0, 6.0, 2 },
                    { 15, 7.0, 1.0, 2 },
                    { 20, 4.0, 4.0, 3 },
                    { 21, 6.0, 7.0, 3 },
                    { 22, 7.0, 1.0, 3 },
                    { 46, 8.0, 7.0, 7 },
                    { 53, 6.0, 1.0, 8 },
                    { 54, 1.0, 2.0, 8 },
                    { 55, 5.0, 1.0, 8 },
                    { 63, 4.0, 8.0, 9 },
                    { 64, 8.0, 2.0, 9 },
                    { 65, 7.0, 1.0, 9 },
                    { 73, 1.0, 6.0, 10 },
                    { 74, 11.0, 4.0, 10 }
                });

            migrationBuilder.UpdateData(
                table: "Fleets",
                keyColumn: "Id",
                keyValue: 1,
                column: "SolarSystemId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Fleets",
                keyColumn: "Id",
                keyValue: 2,
                column: "SolarSystemId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 9.0, 9.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 1.0, 4.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 2.0, 6.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 3.0, 4.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 8.0, 3.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 6.0, 2.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 4.0, 3.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 2.0, 8.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 9.0, 5.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CoordinateY",
                value: 9.0);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 9.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 3.0, 5.0, 1 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 1.0, 7.0, 1 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 6.0, 6.0, 1 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 3.0, 6.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 1.0, 6.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CoordinateX", "SolarSystemId" },
                values: new object[] { 2.0, 2 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CoordinateY", "SolarSystemId" },
                values: new object[] { 3.0, 2 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 2.0, 5.0, 3 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 7.0, 9.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 9.0, 2.0, 4 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 5.0, 6.0, 4 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 6.0, 3.0, 4 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 5.0, 9.0, 4 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 8.0, 7.0, 4 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 6.0, 5.0, 5 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 8.0, 5.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 2.0, 4.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 4.0, 7.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 4.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 4.0, 3.0, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 11.0, 11.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 6.0, 6.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 11.0, 4.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 3.0, 6.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 45,
                column: "CoordinateY",
                value: 6.0);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 1.0, 8.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 4.0, 6.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 49,
                column: "CoordinateX",
                value: 8.0);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 2.0, 7.0, 9 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 8.0, 4.0, 9 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 6.0, 5.0, 9 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CoordinateX", "SolarSystemId" },
                values: new object[] { 5.0, 9 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 7.0, 7.0, 9 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 10.0, 11.0 });

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "Id", "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[,]
                {
                    { 16, 3.0, 2.0, 3 },
                    { 17, 4.0, 6.0, 3 },
                    { 18, 6.0, 5.0, 3 },
                    { 24, 2.0, 1.0, 4 },
                    { 31, 3.0, 6.0, 5 },
                    { 38, 11.0, 6.0, 7 },
                    { 39, 6.0, 10.0, 7 },
                    { 40, 3.0, 8.0, 7 },
                    { 50, 2.0, 4.0, 8 },
                    { 51, 8.0, 1.0, 8 },
                    { 52, 8.0, 3.0, 8 },
                    { 56, 2.0, 10.0, 9 },
                    { 57, 3.0, 4.0, 9 },
                    { 67, 5.0, 11.0, 10 },
                    { 68, 9.0, 2.0, 10 },
                    { 69, 7.0, 11.0, 10 },
                    { 70, 4.0, 9.0, 10 },
                    { 71, 7.0, 2.0, 10 },
                    { 72, 3.0, 3.0, 10 }
                });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5597));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5598));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5605));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5606));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 9,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 10,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 11,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 12,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 13,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 14,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 15,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 16,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5643));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 17,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 18,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5697) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5698) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5698) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5706) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5707) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5707) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5718) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5718) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5719) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 13, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 13, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5726) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 13, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5726) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 16, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5748) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 16, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5749) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 16, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5749) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 17, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 17, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 17, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 18, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5767) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 18, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5767) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 18, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5768) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 19, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5775) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 19, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5776) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 19, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5776) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 23, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 23, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 23, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5811) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 24, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5819) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 24, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 24, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 25, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5827) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 25, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 25, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 26, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5834) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 26, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5835) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 26, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5835) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 27, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5845) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 27, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5846) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 27, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5847) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 28, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5853) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 28, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5853) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 28, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5854) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 29, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 29, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5861) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 29, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5861) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 31, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 31, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 31, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5926) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 32, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5935) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 32, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5936) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 32, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5937) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 33, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5948) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 33, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5949) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 33, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5949) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 34, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 34, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 34, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5959) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 35, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5964) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 35, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5965) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 35, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5965) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 36, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5972) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 36, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5973) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 36, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(5973) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 37, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6042) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 37, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6043) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 37, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6043) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 38, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6051) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 38, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 38, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 39, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6058) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 39, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6059) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 39, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6060) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 40, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6066) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 40, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6066) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 40, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6067) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 94,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6077));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 95,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 96,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 97,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 98,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 99,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 100,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 101,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6096));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 102,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6096));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 103,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 104,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 105,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 106,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 107,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 108,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 47, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6149) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 47, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6150) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 47, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6150) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 48, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6158) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 48, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6159) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 48, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6160) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 49, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6165) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 49, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6166) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 49, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6167) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 50, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6174) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 50, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6175) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 50, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6175) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 51, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6186) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 51, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6187) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 51, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6187) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 52, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6194) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 52, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6194) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 52, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6195) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 56, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6213) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 56, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 56, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6215) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 57, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6249) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 57, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6249) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 57, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 58, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6256) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 58, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6257) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 58, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6257) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 59, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6263) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 59, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6264) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 59, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6265) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 60, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6276) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 60, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6276) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 60, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6277) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 61, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6282) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 61, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6283) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 61, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6284) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 62, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6292) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 62, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6292) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 62, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6293) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 66, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6312) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 66, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6312) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 66, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6313) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 67, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6347) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 67, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6348) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 67, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6349) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 68, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6354) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 68, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6355) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 68, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6355) });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "GovernorCardId", "IsColonized", "PlanetId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 157, null, false, 69, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6362), null },
                    { 158, null, false, 69, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6362), null },
                    { 159, null, false, 69, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6363), null },
                    { 160, null, false, 70, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6374), null },
                    { 161, null, false, 70, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6375), null },
                    { 162, null, false, 70, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6375), null },
                    { 163, null, false, 71, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6381), null },
                    { 164, null, false, 71, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6382), null },
                    { 165, null, false, 71, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6383), null },
                    { 166, null, false, 72, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6389), null },
                    { 167, null, false, 72, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6389), null },
                    { 168, null, false, 72, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6390), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fleets_SolarSystemId1",
                table: "Fleets",
                column: "SolarSystemId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Fleets_SolarSystems_SolarSystemId1",
                table: "Fleets",
                column: "SolarSystemId1",
                principalTable: "SolarSystems",
                principalColumn: "Id");
        }
    }
}
