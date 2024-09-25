using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nexus.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddFleetsAndShips : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fleet_AspNetUsers_UserId",
                table: "Fleet");

            migrationBuilder.DropForeignKey(
                name: "FK_Fleet_Cards_AdmiralCardId",
                table: "Fleet");

            migrationBuilder.DropForeignKey(
                name: "FK_Fleet_SolarSystems_SolarSystemId",
                table: "Fleet");

            migrationBuilder.DropForeignKey(
                name: "FK_Ship_Fleet_FleetId",
                table: "Ship");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ship",
                table: "Ship");

            migrationBuilder.DropIndex(
                name: "IX_Ship_FleetId",
                table: "Ship");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fleet",
                table: "Fleet");

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 22);

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
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 30);

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
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 59);

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
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.RenameTable(
                name: "Ship",
                newName: "Ships");

            migrationBuilder.RenameTable(
                name: "Fleet",
                newName: "Fleets");

            migrationBuilder.RenameColumn(
                name: "FleetId",
                table: "Ships",
                newName: "Strenght");

            migrationBuilder.RenameIndex(
                name: "IX_Fleet_UserId",
                table: "Fleets",
                newName: "IX_Fleets_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Fleet_SolarSystemId",
                table: "Fleets",
                newName: "IX_Fleets_SolarSystemId");

            migrationBuilder.RenameIndex(
                name: "IX_Fleet_AdmiralCardId",
                table: "Fleets",
                newName: "IX_Fleets_AdmiralCardId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Ships",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Ability",
                table: "Ships",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CargoCapacity",
                table: "Ships",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreditsCost",
                table: "Ships",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Health",
                table: "Ships",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HydrogenCost",
                table: "Ships",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Maniobrability",
                table: "Ships",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MicrochipsCost",
                table: "Ships",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MineralsCost",
                table: "Ships",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Shields",
                table: "Ships",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Speed",
                table: "Ships",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Fleets",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ships",
                table: "Ships",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fleets",
                table: "Fleets",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "FleetShips",
                columns: table => new
                {
                    FleetId = table.Column<int>(type: "int", nullable: false),
                    ShipId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FleetShips", x => new { x.FleetId, x.ShipId });
                    table.ForeignKey(
                        name: "FK_FleetShips_Fleets_FleetId",
                        column: x => x.FleetId,
                        principalTable: "Fleets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FleetShips_Ships_ShipId",
                        column: x => x.ShipId,
                        principalTable: "Ships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 9.0, 3.0, 6 });

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
                    { 54, 10.0, 11.0, 7 },
                    { 62, 8.0, 1.0, 8 },
                    { 63, 9.0, 3.0, 8 },
                    { 64, 7.0, 9.0, 8 },
                    { 69, 2.0, 4.0, 9 }
                });

            migrationBuilder.InsertData(
                table: "Fleets",
                columns: new[] { "Id", "AdmiralCardId", "CoordinateX", "CoordinateY", "Name", "SolarSystemId", "UserId" },
                values: new object[,]
                {
                    { 1, null, 2.0, 3.0, "Alpha Fleet", 1, "33b576ef-5997-4fe9-b93e-c0ad1cabf6e5" },
                    { 2, null, 5.0, 6.0, "Beta Fleet", 1, "33b576ef-5997-4fe9-b93e-c0ad1cabf6e5" }
                });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 9.0, 6.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 2,
                column: "CoordinateY",
                value: 6.0);

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
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 5.0, 4.0 });

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
                keyValue: 9,
                column: "CoordinateX",
                value: 1.0);

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
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 6.0, 1.0 });

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
                column: "CoordinateX",
                value: 4.0);

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
                keyValue: 7,
                columns: new[] { "CoordinateX", "SolarSystemId" },
                values: new object[] { 3.0, 2 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 8.0, 3.0, 2 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 4.0, 3.0, 2 });

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
                keyValue: 14,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 4.0, 2.0, 3 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 1.0, 4.0, 3 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 1.0, 2.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CoordinateX", "SolarSystemId" },
                values: new object[] { 4.0, 4 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 11.0, 2.0, 4 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 6.0, 5.0, 4 });

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
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 8.0, 10.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 10.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 7.0, 5.0 });

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
                columns: new[] { "CoordinateX", "SolarSystemId" },
                values: new object[] { 7.0, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 5.0, 4.0, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 2.0, 4.0, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 11.0, 8.0, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 4.0, 7.0, 8 });

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
                columns: new[] { "CoordinateX", "SolarSystemId" },
                values: new object[] { 6.0, 8 });

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "Id", "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[,]
                {
                    { 10, 1.0, 5.0, 2 },
                    { 22, 6.0, 10.0, 4 },
                    { 23, 1.0, 1.0, 4 },
                    { 24, 11.0, 8.0, 4 },
                    { 28, 6.0, 10.0, 5 },
                    { 29, 9.0, 7.0, 5 },
                    { 30, 7.0, 2.0, 5 },
                    { 38, 7.0, 2.0, 6 },
                    { 46, 2.0, 8.0, 7 },
                    { 57, 10.0, 10.0, 8 },
                    { 58, 1.0, 4.0, 8 },
                    { 59, 9.0, 5.0, 8 },
                    { 65, 4.0, 6.0, 9 },
                    { 66, 6.0, 7.0, 9 },
                    { 67, 5.0, 2.0, 9 },
                    { 68, 7.0, 4.0, 9 },
                    { 70, 5.0, 2.0, 10 },
                    { 71, 7.0, 8.0, 10 },
                    { 72, 1.0, 3.0, 10 },
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
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2565));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 20,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2566));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 21,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2566));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 22,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2571));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 23,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 24,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 25,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2584));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 26,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2584));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 27,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2585));

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
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2641));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 35,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2641));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 36,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2642));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 37,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2648));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 38,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 39,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 40,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 41,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 42,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 43,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2661));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 44,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2661));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 45,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(2661));

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

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "GovernorCardId", "IsColonized", "PlanetId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 154, null, false, 60, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3054), null },
                    { 155, null, false, 60, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3054), null },
                    { 156, null, false, 60, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3054), null },
                    { 157, null, false, 61, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3060), null },
                    { 158, null, false, 61, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3060), null },
                    { 159, null, false, 61, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3060), null }
                });

            migrationBuilder.InsertData(
                table: "Ships",
                columns: new[] { "Id", "Ability", "CargoCapacity", "CreditsCost", "Description", "Function", "Health", "HydrogenCost", "Maniobrability", "MicrochipsCost", "MineralsCost", "Name", "Shields", "Speed", "Strenght" },
                values: new object[,]
                {
                    { 1, 5, 1000, 1000, null, 0, 200, 50, 10, 100, 500, "Lanzadera", 30, 8, 50 },
                    { 2, 6, 2000, 1500, null, 0, 300, 100, 8, 150, 700, "Carguero", 20, 7, 40 },
                    { 3, 15, 50, 500, null, 1, 80, 30, 20, 50, 300, "Dron de ataque", 40, 12, 100 },
                    { 4, 20, 80, 1200, null, 2, 150, 80, 18, 120, 600, "Caza clase K", 50, 10, 120 },
                    { 5, 25, 100, 2000, null, 2, 180, 100, 17, 150, 800, "Caza clase Vengador", 80, 12, 180 },
                    { 6, 30, 150, 3000, null, 2, 300, 150, 15, 200, 1000, "Fragata ligera", 100, 9, 200 },
                    { 7, 35, 200, 4000, null, 3, 400, 200, 12, 300, 1500, "Fragata pesada", 120, 8, 250 },
                    { 8, 40, 250, 5000, null, 3, 500, 300, 10, 400, 2000, "Destructor", 150, 7, 300 },
                    { 9, 45, 300, 7000, null, 3, 600, 400, 9, 500, 2500, "Crucero", 180, 6, 350 },
                    { 10, 50, 500, 10000, null, 4, 800, 500, 8, 600, 3000, "Acorazado", 200, 5, 400 }
                });

            migrationBuilder.InsertData(
                table: "FleetShips",
                columns: new[] { "FleetId", "ShipId", "Quantity" },
                values: new object[,]
                {
                    { 1, 4, 32 },
                    { 1, 6, 10 },
                    { 2, 5, 24 },
                    { 2, 8, 8 },
                    { 2, 10, 1 }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "GovernorCardId", "IsColonized", "PlanetId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 151, null, false, 59, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3032), null },
                    { 152, null, false, 59, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3032), null },
                    { 153, null, false, 59, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3033), null },
                    { 160, null, false, 65, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3072), null },
                    { 161, null, false, 65, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3072), null },
                    { 162, null, false, 65, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3073), null },
                    { 163, null, false, 66, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3078), null },
                    { 164, null, false, 66, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3079), null },
                    { 165, null, false, 66, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3079), null },
                    { 166, null, false, 67, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3085), null },
                    { 167, null, false, 67, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3086), null },
                    { 168, null, false, 67, new DateTime(2024, 9, 25, 17, 48, 51, 394, DateTimeKind.Utc).AddTicks(3086), null },
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

            migrationBuilder.CreateIndex(
                name: "IX_FleetShips_ShipId",
                table: "FleetShips",
                column: "ShipId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fleets_AspNetUsers_UserId",
                table: "Fleets",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fleets_Cards_AdmiralCardId",
                table: "Fleets",
                column: "AdmiralCardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Fleets_SolarSystems_SolarSystemId",
                table: "Fleets",
                column: "SolarSystemId",
                principalTable: "SolarSystems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fleets_AspNetUsers_UserId",
                table: "Fleets");

            migrationBuilder.DropForeignKey(
                name: "FK_Fleets_Cards_AdmiralCardId",
                table: "Fleets");

            migrationBuilder.DropForeignKey(
                name: "FK_Fleets_SolarSystems_SolarSystemId",
                table: "Fleets");

            migrationBuilder.DropTable(
                name: "FleetShips");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ships",
                table: "Ships");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fleets",
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
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 62);

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
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Fleets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Fleets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 22);

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
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 30);

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
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 58);

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
                table: "Ships",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 59);

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
                keyValue: 68);

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

            migrationBuilder.DropColumn(
                name: "Ability",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "CargoCapacity",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "CreditsCost",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "Health",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "HydrogenCost",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "Maniobrability",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "MicrochipsCost",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "MineralsCost",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "Shields",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "Speed",
                table: "Ships");

            migrationBuilder.RenameTable(
                name: "Ships",
                newName: "Ship");

            migrationBuilder.RenameTable(
                name: "Fleets",
                newName: "Fleet");

            migrationBuilder.RenameColumn(
                name: "Strenght",
                table: "Ship",
                newName: "FleetId");

            migrationBuilder.RenameIndex(
                name: "IX_Fleets_UserId",
                table: "Fleet",
                newName: "IX_Fleet_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Fleets_SolarSystemId",
                table: "Fleet",
                newName: "IX_Fleet_SolarSystemId");

            migrationBuilder.RenameIndex(
                name: "IX_Fleets_AdmiralCardId",
                table: "Fleet",
                newName: "IX_Fleet_AdmiralCardId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Ship",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Fleet",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ship",
                table: "Ship",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fleet",
                table: "Fleet",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 7.0, 9.0, 7 });

            migrationBuilder.InsertData(
                table: "AsteroidField",
                columns: new[] { "Id", "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[,]
                {
                    { 10, 11.0, 4.0, 1 },
                    { 22, 4.0, 2.0, 3 },
                    { 23, 3.0, 1.0, 3 },
                    { 24, 10.0, 1.0, 3 },
                    { 28, 3.0, 4.0, 4 },
                    { 29, 4.0, 5.0, 4 },
                    { 30, 5.0, 4.0, 4 },
                    { 38, 7.0, 1.0, 6 },
                    { 46, 2.0, 3.0, 7 },
                    { 57, 4.0, 2.0, 9 },
                    { 58, 2.0, 1.0, 9 },
                    { 59, 2.0, 7.0, 9 }
                });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 6.0, 8.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 2,
                column: "CoordinateY",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 11.0, 11.0 });

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
                values: new object[] { 3.0, 8.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 7.0, 3.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 9.0, 9.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 7.0, 6.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 9,
                column: "CoordinateX",
                value: 7.0);

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 4.0, 4.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 1.0, 2.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 4.0, 5.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 9.0, 7.0 });

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
                values: new object[] { 2.0, 11.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 10.0, 9.0, 1 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CoordinateX", "SolarSystemId" },
                values: new object[] { 1.0, 1 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 9.0, 4.0, 1 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 7.0, 6.0, 1 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 4.0, 7.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 2.0, 7.0, 2 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 5.0, 3.0, 2 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 6.0, 1.0, 2 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 10.0, 8.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CoordinateX", "SolarSystemId" },
                values: new object[] { 7.0, 3 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 2.0, 8.0, 3 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 3.0, 10.0, 3 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 6.0, 6.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 1.0, 7.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 7.0, 2.0, 4 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 6.0, 9.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 1.0, 7.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 7.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 9.0, 2.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 5.0, 4.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 8.0, 5.0, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CoordinateY", "SolarSystemId" },
                values: new object[] { 6.0, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 1.0, 5.0, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 5.0, 4.0, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 6.0, 1.0, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CoordinateX", "SolarSystemId" },
                values: new object[] { 11.0, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 9.0, 5.0, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 6.0, 9.0, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 5.0, 4.0, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CoordinateX", "SolarSystemId" },
                values: new object[] { 9.0, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 4.0, 9.0, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 3.0, 1.0, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 4.0, 7.0, 9 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 2.0, 5.0, 9 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 7.0, 5.0, 10 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CoordinateX", "SolarSystemId" },
                values: new object[] { 5.0, 10 });

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "Id", "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[,]
                {
                    { 12, 6.0, 6.0, 2 },
                    { 17, 9.0, 5.0, 3 },
                    { 18, 9.0, 3.0, 3 },
                    { 35, 1.0, 2.0, 6 },
                    { 36, 1.0, 6.0, 6 },
                    { 44, 8.0, 3.0, 7 },
                    { 54, 5.0, 4.0, 9 },
                    { 62, 2.0, 3.0, 10 },
                    { 63, 6.0, 3.0, 10 }
                });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5101));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5101));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 9,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 10,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 11,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 12,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 13,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 14,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 15,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 16,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5125));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 17,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5126));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 18,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5126));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 19,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 20,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 21,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 22,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 23,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 24,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 25,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 26,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 27,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5184) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5184) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5184) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5188) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5189) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5189) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 34,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 35,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 36,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 37,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 38,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 39,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 40,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 41,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 42,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 43,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5246));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 44,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5246));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 45,
                column: "UpdatedAt",
                value: new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 17, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5252) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 17, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5252) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 17, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5253) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 18, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5258) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 18, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5258) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 18, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5259) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 19, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5263) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 19, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5263) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 19, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5263) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 20, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5271) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 20, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5271) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 20, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5271) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 21, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5275) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 21, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5275) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 21, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5276) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 25, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5285) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 25, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5285) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 25, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5286) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 26, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5291) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 26, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5291) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 26, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5319) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 27, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5323) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 27, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5323) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 27, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5323) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 31, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5337) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 31, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5337) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 31, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5338) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 32, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5343) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 32, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5343) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 32, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5343) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 33, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5348) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 33, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5348) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 33, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5348) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 34, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 34, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 34, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 35, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 35, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5361) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 35, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5361) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 36, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5366) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 36, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5366) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 36, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5366) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 37, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5370) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 37, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5371) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 37, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5371) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 39, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5407) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 39, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5408) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 39, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5408) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 40, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5413) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 40, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5413) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 40, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5413) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 41, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5418) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 41, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5418) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 41, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5419) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 42, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5423) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 42, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5424) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 42, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5424) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 43, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 43, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 43, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 44, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5435) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 44, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5435) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 44, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5436) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 47, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5445) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 47, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5446) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 47, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5446) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 48, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5481) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 48, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5481) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 48, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5482) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 49, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5486) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 49, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5487) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 49, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5487) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 50, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5491) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 50, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5492) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 50, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5492) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 51, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5498) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 51, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5498) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 51, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5499) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 52, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5503) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 52, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5503) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 52, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5504) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 53, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5509) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 53, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5509) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 53, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5509) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 54, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5528) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 54, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5529) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 54, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5529) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 55, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5534) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 55, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5534) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 55, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5535) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 56, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5539) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 56, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5539) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 56, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5539) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 60, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 60, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5551) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 60, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5551) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 61, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5555) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 61, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5555) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 61, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5556) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 62, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5562) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 62, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5562) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 62, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5562) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 63, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5566) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 63, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5566) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 63, new DateTime(2024, 9, 25, 16, 26, 26, 388, DateTimeKind.Utc).AddTicks(5566) });

            migrationBuilder.CreateIndex(
                name: "IX_Ship_FleetId",
                table: "Ship",
                column: "FleetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fleet_AspNetUsers_UserId",
                table: "Fleet",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fleet_Cards_AdmiralCardId",
                table: "Fleet",
                column: "AdmiralCardId",
                principalTable: "Cards",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Fleet_SolarSystems_SolarSystemId",
                table: "Fleet",
                column: "SolarSystemId",
                principalTable: "SolarSystems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ship_Fleet_FleetId",
                table: "Ship",
                column: "FleetId",
                principalTable: "Fleet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
