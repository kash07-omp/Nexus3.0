using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nexus.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FleetMapMove : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fleets_SolarSystems_SolarSystemId",
                table: "Fleets");

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 12);

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
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 69);

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
                keyValue: 30);

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
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 65);

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

            migrationBuilder.AlterColumn<int>(
                name: "CoordinateY",
                table: "Fleets",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "CoordinateX",
                table: "Fleets",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<int>(
                name: "SolarSystemId1",
                table: "Fleets",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FleetMovementPaths",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FleetId = table.Column<int>(type: "int", nullable: false),
                    FromX = table.Column<int>(type: "int", nullable: false),
                    FromY = table.Column<int>(type: "int", nullable: false),
                    ToX = table.Column<int>(type: "int", nullable: false),
                    ToY = table.Column<int>(type: "int", nullable: false),
                    ArrivalTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DepartureTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FleetMovementPaths", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FleetMovementPaths_Fleets_FleetId",
                        column: x => x.FleetId,
                        principalTable: "Fleets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 1.0, 2.0, 8 });

            migrationBuilder.UpdateData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 4.0, 8.0, 9 });

            migrationBuilder.UpdateData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 8.0, 2.0, 9 });

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
                    { 30, 2.0, 5.0, 4 },
                    { 46, 8.0, 7.0, 7 },
                    { 53, 6.0, 1.0, 8 },
                    { 55, 5.0, 1.0, 8 },
                    { 65, 7.0, 1.0, 9 },
                    { 73, 1.0, 6.0, 10 },
                    { 74, 11.0, 4.0, 10 }
                });

            migrationBuilder.UpdateData(
                table: "Fleets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId1" },
                values: new object[] { 2, 3, null });

            migrationBuilder.UpdateData(
                table: "Fleets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId1" },
                values: new object[] { 5, 6, null });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 1,
                column: "CoordinateY",
                value: 9.0);

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
                column: "CoordinateX",
                value: 3.0);

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
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 3.0, 5.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 1.0, 7.0 });

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
                keyValue: 13,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 5.0, 3.0, 2 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 16,
                column: "CoordinateX",
                value: 3.0);

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
                keyValue: 24,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 2.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 9.0, 2.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 5.0, 6.0 });

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
                columns: new[] { "CoordinateX", "SolarSystemId" },
                values: new object[] { 8.0, 4 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 3.0, 6.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 6.0, 5.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CoordinateY", "SolarSystemId" },
                values: new object[] { 5.0, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 2.0, 4.0, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 4.0, 3.0, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 11.0, 6.0, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 6.0, 10.0, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CoordinateY", "SolarSystemId" },
                values: new object[] { 8.0, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 11.0, 11.0, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 6.0, 6.0, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 11.0, 4.0, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CoordinateX", "SolarSystemId" },
                values: new object[] { 1.0, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 4.0, 6.0, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 8.0, 5.0, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 2.0, 4.0, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 8.0, 1.0, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 8.0, 3.0, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 2.0, 10.0, 9 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 3.0, 4.0, 9 });

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
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 5.0, 1.0, 9 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 10.0, 11.0, 10 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CoordinateY", "SolarSystemId" },
                values: new object[] { 11.0, 10 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 9.0, 2.0, 10 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 4.0, 9.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 71,
                column: "CoordinateY",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 72,
                column: "CoordinateX",
                value: 3.0);

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "Id", "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[,]
                {
                    { 12, 2.0, 2.0, 2 },
                    { 17, 4.0, 6.0, 3 },
                    { 18, 6.0, 5.0, 3 },
                    { 35, 4.0, 7.0, 6 },
                    { 36, 4.0, 1.0, 6 },
                    { 44, 3.0, 6.0, 7 },
                    { 45, 1.0, 6.0, 7 },
                    { 62, 7.0, 7.0, 9 },
                    { 69, 7.0, 11.0, 10 }
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
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 41, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6077) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 41, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6078) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 41, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6078) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 42, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6087) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 42, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6088) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 42, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6088) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 43, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6095) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 43, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6096) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 43, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6096) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 44, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6103) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 44, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6104) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 44, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6104) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 45, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6110) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 45, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6111) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 45, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6112) });

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

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 69, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6362) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 69, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6362) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 69, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6363) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 70, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6374) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 70, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6375) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 70, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6375) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 71, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6381) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 71, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6382) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 71, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6383) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 72, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6389) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 72, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6389) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 72, new DateTime(2024, 9, 26, 14, 46, 17, 104, DateTimeKind.Utc).AddTicks(6390) });

            migrationBuilder.CreateIndex(
                name: "IX_Fleets_SolarSystemId1",
                table: "Fleets",
                column: "SolarSystemId1");

            migrationBuilder.CreateIndex(
                name: "IX_FleetMovementPaths_FleetId",
                table: "FleetMovementPaths",
                column: "FleetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fleets_SolarSystems_SolarSystemId",
                table: "Fleets",
                column: "SolarSystemId",
                principalTable: "SolarSystems",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Fleets_SolarSystems_SolarSystemId1",
                table: "Fleets",
                column: "SolarSystemId1",
                principalTable: "SolarSystems",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fleets_SolarSystems_SolarSystemId",
                table: "Fleets");

            migrationBuilder.DropForeignKey(
                name: "FK_Fleets_SolarSystems_SolarSystemId1",
                table: "Fleets");

            migrationBuilder.DropTable(
                name: "FleetMovementPaths");

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
                keyValue: 30);

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
                keyValue: 55);

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
                keyValue: 12);

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
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DropColumn(
                name: "SolarSystemId1",
                table: "Fleets");

            migrationBuilder.AlterColumn<double>(
                name: "CoordinateY",
                table: "Fleets",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "CoordinateX",
                table: "Fleets",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 10.0, 11.0, 7 });

            migrationBuilder.UpdateData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 9.0, 3.0, 8 });

            migrationBuilder.UpdateData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 7.0, 9.0, 8 });

            migrationBuilder.InsertData(
                table: "AsteroidField",
                columns: new[] { "Id", "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[,]
                {
                    { 12, 1.0, 7.0, 2 },
                    { 17, 6.0, 5.0, 3 },
                    { 18, 9.0, 1.0, 3 },
                    { 35, 11.0, 11.0, 5 },
                    { 36, 1.0, 8.0, 5 },
                    { 44, 4.0, 1.0, 6 },
                    { 45, 9.0, 3.0, 6 },
                    { 62, 8.0, 1.0, 8 },
                    { 69, 2.0, 4.0, 9 }
                });

            migrationBuilder.UpdateData(
                table: "Fleets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 2.0, 3.0 });

            migrationBuilder.UpdateData(
                table: "Fleets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 5.0, 6.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 1,
                column: "CoordinateY",
                value: 6.0);

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 3.0, 6.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 4.0, 8.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 4.0, 4.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 5,
                column: "CoordinateX",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 1.0, 2.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 10.0, 7.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 2.0, 7.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 11.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 2.0, 8.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CoordinateY",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 1.0, 3.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 4.0, 9.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 9.0, 4.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 5.0, 1.0, 2 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 1.0, 5.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 6.0, 3.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 1.0, 9.0, 3 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 16,
                column: "CoordinateX",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 4.0, 1.0, 4 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 11.0, 8.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 8.0, 3.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 10.0, 4.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 10.0, 9.0, 5 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 6.0, 10.0, 5 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CoordinateX", "SolarSystemId" },
                values: new object[] { 9.0, 5 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 4.0, 8.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 10.0, 4.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CoordinateY", "SolarSystemId" },
                values: new object[] { 10.0, 5 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 10.0, 1.0, 5 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 7.0, 5.0, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 7.0, 2.0, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 4.0, 7.0, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CoordinateY", "SolarSystemId" },
                values: new object[] { 4.0, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 6.0, 8.0, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 9.0, 8.0, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 2.0, 7.0, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CoordinateX", "SolarSystemId" },
                values: new object[] { 7.0, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 3.0, 1.0, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 7.0, 6.0, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 11.0, 2.0, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 7.0, 2.0, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 5.0, 4.0, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 4.0, 7.0, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 10.0, 10.0, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 1.0, 4.0, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 9.0, 5.0, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 4.0, 3.0, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 6.0, 6.0, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 6.0, 7.0, 9 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CoordinateY", "SolarSystemId" },
                values: new object[] { 2.0, 9 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 7.0, 4.0, 9 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 5.0, 2.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 71,
                column: "CoordinateY",
                value: 8.0);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 72,
                column: "CoordinateX",
                value: 1.0);

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "Id", "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[,]
                {
                    { 7, 3.0, 8.0, 2 },
                    { 8, 8.0, 3.0, 2 },
                    { 9, 4.0, 3.0, 2 },
                    { 14, 4.0, 2.0, 3 },
                    { 15, 1.0, 4.0, 3 },
                    { 20, 11.0, 2.0, 4 },
                    { 21, 6.0, 5.0, 4 },
                    { 22, 6.0, 10.0, 4 },
                    { 30, 7.0, 2.0, 5 },
                    { 46, 2.0, 8.0, 7 },
                    { 53, 2.0, 4.0, 7 },
                    { 55, 11.0, 8.0, 8 },
                    { 65, 4.0, 6.0, 9 },
                    { 73, 9.0, 1.0, 10 },
                    { 74, 6.0, 6.0, 10 },
                    { 75, 2.0, 11.0, 10 }
                });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2464));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 9,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 10,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 11,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 12,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 13,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2544));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 14,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2544));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 15,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 16,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 17,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 18,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2559));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2565) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2566) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2566) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2571) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2572) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2572) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2584) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2584) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2585) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2593) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2594) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2594) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2601) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2601) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2602) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 13, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2641) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 13, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2641) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 13, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2642) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 14, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2648) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 14, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2649) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 14, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2649) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 15, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2654) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 15, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2655) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 15, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2655) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 16, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2661) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 16, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2661) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 16, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2661) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 19, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2672) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 19, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2672) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 19, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2672) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 20, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 20, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 20, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2681) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 21, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2686) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 21, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2686) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 21, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2686) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 22, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2691) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 22, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2692) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 22, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2692) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 23, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2725) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 23, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2726) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 23, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2726) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 24, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2732) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 24, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2732) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 24, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2732) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 25, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2738) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 25, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2738) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 25, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 26, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2745) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 26, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2746) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 26, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2746) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 27, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2755) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 27, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2755) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 27, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2756) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 28, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2762) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 28, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2762) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 28, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2762) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 29, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2768) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 29, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2768) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 29, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2769) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 30, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2774) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 30, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2774) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 30, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2774) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 31, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2804) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 31, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2804) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 31, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2805) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 32, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2811) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 32, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2811) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 32, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2812) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 33, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2819) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 33, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2819) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 33, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2820) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 34, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2825) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 34, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2825) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 34, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2825) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 37, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2839) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 37, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2839) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 37, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2840) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 38, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2847) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 38, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2847) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 38, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2848) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 39, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2853) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 39, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2853) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 39, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2854) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 40, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2859) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 40, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2859) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 40, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2859) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 41, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2893) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 41, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2893) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 41, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2893) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 42, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2899) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 42, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2899) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 42, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2899) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 43, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2905) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 43, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2905) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 43, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2906) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 46, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 46, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 46, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 47, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2926) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 47, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2927) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 47, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2927) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 48, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2932) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 48, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2932) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 48, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2932) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 49, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2938) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 49, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2938) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 49, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2938) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 50, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2947) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 50, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2947) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 50, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2947) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 51, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2982) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 51, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2982) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 51, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2982) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 52, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2988) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 52, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 52, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 53, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2994) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 53, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2994) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 53, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2995) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 55, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3005) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 55, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3005) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 55, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3006) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 56, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3012) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 56, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3012) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 56, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3013) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 57, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3018) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 57, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3018) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 57, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3018) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 58, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3023) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 58, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3024) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 58, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3024) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 59, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3032) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 59, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3032) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 59, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3033) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 60, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3054) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 60, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3054) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 60, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3054) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 61, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3060) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 61, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3060) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 61, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3060) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 65, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3072) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 65, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3072) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 65, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3073) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 66, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3078) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 66, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3079) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 66, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3079) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 67, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3085) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 67, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3086) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 67, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3086) });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "GovernorCardId", "IsColonized", "PlanetId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 169, null, false, 68, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3091), null },
                    { 170, null, false, 68, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3092), null },
                    { 171, null, false, 68, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3092), null },
                    { 172, null, false, 70, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3107), null },
                    { 173, null, false, 70, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3107), null },
                    { 174, null, false, 70, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3107), null },
                    { 175, null, false, 71, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3114), null },
                    { 176, null, false, 71, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3114), null },
                    { 177, null, false, 71, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3114), null },
                    { 178, null, false, 72, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3119), null },
                    { 179, null, false, 72, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3119), null },
                    { 180, null, false, 72, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3120), null },
                    { 181, null, false, 73, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3154), null },
                    { 182, null, false, 73, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3155), null },
                    { 183, null, false, 73, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3155), null },
                    { 184, null, false, 74, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3163), null },
                    { 185, null, false, 74, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3164), null },
                    { 186, null, false, 74, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3164), null },
                    { 187, null, false, 75, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3169), null },
                    { 188, null, false, 75, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3169), null },
                    { 189, null, false, 75, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3170), null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Fleets_SolarSystems_SolarSystemId",
                table: "Fleets",
                column: "SolarSystemId",
                principalTable: "SolarSystems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
