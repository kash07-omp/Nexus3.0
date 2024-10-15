using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nexus.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FleetQueue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 44);

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
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 3);

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
                keyValue: 20);

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
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 68);

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
                table: "Regions",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.CreateTable(
                name: "ShipBuildQueues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegionId = table.Column<int>(type: "int", nullable: false),
                    FleetId = table.Column<int>(type: "int", nullable: false),
                    ShipId = table.Column<int>(type: "int", nullable: false),
                    CompletionTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipBuildQueues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShipBuildQueues_Fleets_FleetId",
                        column: x => x.FleetId,
                        principalTable: "Fleets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShipBuildQueues_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShipBuildQueues_Ships_ShipId",
                        column: x => x.ShipId,
                        principalTable: "Ships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 28,
                column: "CoordinateX",
                value: 9);

            migrationBuilder.UpdateData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 3, 5 });

            migrationBuilder.UpdateData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 6, 3 });

            migrationBuilder.UpdateData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 77,
                column: "CoordinateX",
                value: 11);

            migrationBuilder.UpdateData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 9, 11 });

            migrationBuilder.InsertData(
                table: "AsteroidField",
                columns: new[] { "Id", "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[,]
                {
                    { 3, 4, 1, 1 },
                    { 10, 6, 4, 2 },
                    { 11, 2, 1, 2 },
                    { 12, 6, 5, 2 },
                    { 20, 10, 6, 3 },
                    { 36, 2, 3, 5 },
                    { 37, 1, 3, 5 },
                    { 38, 5, 8, 5 },
                    { 46, 5, 6, 6 },
                    { 52, 8, 8, 7 },
                    { 53, 3, 8, 7 },
                    { 58, 2, 4, 8 },
                    { 59, 1, 6, 8 },
                    { 68, 5, 2, 9 },
                    { 76, 7, 1, 10 }
                });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 1,
                column: "CoordinateY",
                value: 3);

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 6, 3 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 10, 11 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 1, 9 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 11, 9 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 6, 10 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 8, 6 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 1, 5 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 7, 6 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 10,
                column: "CoordinateY",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 7, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CoordinateX",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 5, 9, 2 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 4, 6, 2 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 4, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 7, 9, 2 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 8,
                column: "SolarSystemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 3, 8, 2 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 8, 3, 3 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 8, 10 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 7, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 10, 1 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 18,
                column: "CoordinateY",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 4, 11 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 6, 6, 4 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 22,
                column: "CoordinateX",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 8, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 7, 4 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 9, 9 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 7, 9 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 3, 10 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 3, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 33,
                column: "CoordinateX",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 5, 11 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 4, 10 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 41,
                column: "CoordinateY",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 6, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 1, 3, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 1, 3 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 48,
                column: "CoordinateX",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 5, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 8, 4 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 5, 4 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 5, 4 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 2, 9, 9 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 62,
                column: "CoordinateY",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 64,
                column: "CoordinateY",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 65,
                column: "CoordinateY",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 66,
                column: "CoordinateX",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 69,
                column: "CoordinateY",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 9, 4 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 4, 5 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 2, 11 });

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "Id", "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[,]
                {
                    { 14, 11, 3, 3 },
                    { 27, 4, 8, 4 },
                    { 35, 11, 11, 5 },
                    { 44, 2, 6, 6 },
                    { 54, 6, 2, 8 },
                    { 55, 7, 6, 8 },
                    { 61, 3, 1, 9 }
                });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(326));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(327));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(341));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedAt",
                value: new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(342));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(359) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(359) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(359) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(366) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(398) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(399) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(405) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(405) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(406) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(412) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(413) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(414) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(422) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(422) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(423) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(428) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(428) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(428) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 13, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(441) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 13, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(441) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 13, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(442) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 14, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(448) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 14, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(449) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 14, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(449) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 15, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 15, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 15, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 16, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(460) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 16, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(482) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 16, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(482) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 17, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(491) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 17, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(492) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 17, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(492) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 18, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(497) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 18, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(498) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 18, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(498) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 19, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(503) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 19, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(503) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 19, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(504) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 21, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(512) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 21, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(513) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 21, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(513) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 22, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(521) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 22, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(521) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 22, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(521) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 23, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(526) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 23, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(527) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 23, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(527) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 24, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 24, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(533) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 24, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(533) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 25, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(566) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 25, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(567) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 25, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(567) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 26, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(571) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 26, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(572) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 26, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(572) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 27, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(576) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 27, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(576) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 27, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(578) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 30, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(591) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 30, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(592) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 30, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(592) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 31, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(599) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 31, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(600) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 31, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(600) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 32, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(605) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 32, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(605) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 32, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(605) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 33, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(610) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 33, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(611) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 33, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(611) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 34, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(640) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 34, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(641) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 34, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(641) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 35, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(646) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 35, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(646) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 35, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(647) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 39, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(660) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 39, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(660) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 39, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(661) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 40, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(666) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 40, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(667) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 40, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(667) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 41, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(671) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 41, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(672) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 41, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(672) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 42, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(677) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 42, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(677) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 42, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(678) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 43, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(688) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 43, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(689) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 43, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(689) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 44, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(716) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 44, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(716) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 44, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(717) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 45, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(722) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 45, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(722) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 45, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(723) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 47, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(735) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 47, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(736) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 47, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(736) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 48, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(741) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 48, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(742) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 48, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(742) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 49, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(747) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 49, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(747) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 49, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(748) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 50, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(753) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 50, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(754) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 50, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(754) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 51, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(761) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 51, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(762) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 51, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(762) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 54, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(773) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 54, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(774) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 54, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(774) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 55, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(801) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 55, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(801) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 55, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(801) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 56, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(807) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 56, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(807) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 56, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(808) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 57, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(813) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 57, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(814) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 57, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(814) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 60, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(825) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 60, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(825) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 60, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(826) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 61, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(832) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 61, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(833) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 61, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(833) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 62, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(838) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 62, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(838) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 62, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(839) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 63, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(843) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 63, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(843) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 63, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(844) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 64, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(867) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 64, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(867) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 64, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(868) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 65, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(873) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 65, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(874) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 65, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(874) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 66, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(879) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 66, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 66, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 69, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(893) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 69, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(893) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 69, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(893) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 70, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(900) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 70, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(900) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 70, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(901) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 71, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(905) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 71, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(905) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 71, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(906) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 72, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(911) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 72, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(911) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 72, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(912) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 73, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(948) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 73, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(949) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 73, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(949) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 74, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(954) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 74, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(955) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 74, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(955) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 75, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(959) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 75, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(960) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 75, new DateTime(2024, 10, 15, 15, 24, 23, 141, DateTimeKind.Utc).AddTicks(960) });

            migrationBuilder.CreateIndex(
                name: "IX_ShipBuildQueues_FleetId",
                table: "ShipBuildQueues",
                column: "FleetId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipBuildQueues_RegionId",
                table: "ShipBuildQueues",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipBuildQueues_ShipId",
                table: "ShipBuildQueues",
                column: "ShipId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShipBuildQueues");

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 3);

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
                keyValue: 20);

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
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 44);

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

            migrationBuilder.UpdateData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 28,
                column: "CoordinateX",
                value: 5);

            migrationBuilder.UpdateData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 4, 7 });

            migrationBuilder.UpdateData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 4, 7 });

            migrationBuilder.UpdateData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 77,
                column: "CoordinateX",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 7, 3 });

            migrationBuilder.InsertData(
                table: "AsteroidField",
                columns: new[] { "Id", "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[,]
                {
                    { 14, 1, 6, 2 },
                    { 27, 4, 6, 4 },
                    { 35, 3, 5, 5 },
                    { 44, 10, 2, 6 },
                    { 54, 11, 7, 7 },
                    { 55, 4, 10, 7 },
                    { 61, 7, 1, 8 },
                    { 79, 5, 6, 10 }
                });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 1,
                column: "CoordinateY",
                value: 1);

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 7, 5 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 7, 3 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 9, 9 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 5, 8 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 6, 4 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 8, 1 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 10,
                column: "CoordinateY",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 5, 10 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CoordinateX",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 3, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 7, 5, 1 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 11, 7, 1 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 11, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 8,
                column: "SolarSystemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 2, 9, 1 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 7, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 5, 3 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 8, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 3, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 18,
                column: "CoordinateY",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 6, 1 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 1, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 22,
                column: "CoordinateX",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 6, 3 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 2, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 6, 1 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 6, 3 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 7, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 33,
                column: "CoordinateX",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 1, 5 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 11, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 1, 9 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 41,
                column: "CoordinateY",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 8, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 3, 8, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 7, 2 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 48,
                column: "CoordinateX",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 3, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 3, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 1, 5, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 62,
                column: "CoordinateY",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 4, 5 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 64,
                column: "CoordinateY",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 65,
                column: "CoordinateY",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 66,
                column: "CoordinateX",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 69,
                column: "CoordinateY",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 7, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 1, 10 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 11, 9 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 3, 6 });

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "Id", "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[,]
                {
                    { 3, 4, 3, 1 },
                    { 10, 3, 1, 2 },
                    { 11, 4, 6, 2 },
                    { 12, 6, 7, 2 },
                    { 20, 3, 8, 3 },
                    { 36, 3, 3, 6 },
                    { 37, 3, 8, 6 },
                    { 38, 5, 9, 6 },
                    { 46, 5, 1, 7 },
                    { 52, 5, 6, 7 },
                    { 53, 9, 5, 7 },
                    { 58, 1, 3, 8 },
                    { 59, 3, 1, 8 },
                    { 68, 11, 3, 10 },
                    { 76, 5, 4, 10 }
                });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedAt",
                value: new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7115) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7115) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7115) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7129) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7129) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7129) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7138) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7138) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7138) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7161) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7162) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7168) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7168) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7169) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7173) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7173) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7173) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7178) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7179) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7179) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7188) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7188) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7189) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7194) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7195) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7195) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7200) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7201) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7201) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 13, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7206) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 13, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7206) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 13, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7206) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 15, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 15, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 15, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 16, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7245) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 16, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7245) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 16, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7245) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 17, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7249) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 17, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7249) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 17, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7250) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 18, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7254) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 18, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7254) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 18, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7255) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 19, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7261) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 19, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 19, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 20, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7267) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 20, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7267) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 20, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7268) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 21, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7272) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 21, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7272) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 21, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7272) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 22, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 22, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 22, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7281) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 23, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7285) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 23, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7285) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 23, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7286) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 24, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7302) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 24, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7303) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 24, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7303) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 25, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7307) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 25, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7307) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 25, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7308) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 26, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7314) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 26, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7314) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 26, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7315) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 30, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7334) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 30, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7334) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 30, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7334) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 31, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 31, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 31, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 32, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7344) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 32, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7344) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 32, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7345) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 33, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7348) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 33, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7349) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 33, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7349) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 34, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7385) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 34, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7385) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 34, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7386) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 36, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7395) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 36, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7395) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 36, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7395) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 37, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7401) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 37, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7401) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 37, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7401) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 38, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7406) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 38, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7407) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 38, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7407) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 39, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7411) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 39, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7411) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 39, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7412) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 40, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7419) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 40, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7419) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 40, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7419) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 41, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7448) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 41, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7448) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 41, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7448) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 42, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7453) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 42, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7453) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 42, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7454) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 43, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7458) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 43, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7458) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 43, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7458) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 45, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 45, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 45, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7468) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 46, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7472) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 46, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7473) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 46, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7473) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 47, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7477) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 47, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7477) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 47, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7477) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 48, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7482) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 48, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7482) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 48, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7482) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 49, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7489) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 49, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7490) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 49, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7490) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 50, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 50, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 50, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 51, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 51, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 51, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 52, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7523) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 52, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7523) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 52, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7524) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 53, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7527) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 53, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7528) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 53, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7528) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 56, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7538) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 56, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7538) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 56, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7539) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 57, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7543) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 57, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7544) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 57, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7544) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 58, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7548) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 58, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7548) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 58, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7548) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 59, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7553) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 59, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7553) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 59, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7553) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 60, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7562) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 60, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 60, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 62, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7588) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 62, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7588) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 62, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7589) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 63, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7593) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 63, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7593) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 63, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7594) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 64, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7599) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 64, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7599) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 64, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7599) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 65, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7603) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 65, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7603) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 65, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7604) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 66, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 66, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 66, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 68, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7618) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 68, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7619) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 68, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7619) });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "GovernorCardId", "IsColonized", "PlanetId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 175, null, false, 69, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7623), null },
                    { 176, null, false, 69, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7624), null },
                    { 177, null, false, 69, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7641), null },
                    { 178, null, false, 70, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7646), null },
                    { 179, null, false, 70, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7646), null },
                    { 180, null, false, 70, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7646), null },
                    { 181, null, false, 71, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7650), null },
                    { 182, null, false, 71, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7651), null },
                    { 183, null, false, 71, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7651), null },
                    { 184, null, false, 72, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7657), null },
                    { 185, null, false, 72, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7658), null },
                    { 186, null, false, 72, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7658), null },
                    { 187, null, false, 73, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7662), null },
                    { 188, null, false, 73, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7663), null },
                    { 189, null, false, 73, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7663), null },
                    { 190, null, false, 74, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7667), null },
                    { 191, null, false, 74, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7667), null },
                    { 192, null, false, 74, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7667), null },
                    { 193, null, false, 75, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7672), null },
                    { 194, null, false, 75, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7672), null },
                    { 195, null, false, 75, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7673), null },
                    { 196, null, false, 76, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7677), null },
                    { 197, null, false, 76, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7677), null },
                    { 198, null, false, 76, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7678), null }
                });
        }
    }
}
