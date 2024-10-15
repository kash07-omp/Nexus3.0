using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nexus.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FleetInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 3);

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
                keyValue: 13);

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
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 63);

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
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "Ships",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "CoordinateY",
                table: "Planets",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "CoordinateX",
                table: "Planets",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "CoordinateY",
                table: "JumpGate",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "CoordinateX",
                table: "JumpGate",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "CoordinateY",
                table: "AsteroidField",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "CoordinateX",
                table: "AsteroidField",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 3, 5, 5 });

            migrationBuilder.UpdateData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 11, 7, 7 });

            migrationBuilder.UpdateData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 7, 1, 8 });

            migrationBuilder.InsertData(
                table: "AsteroidField",
                columns: new[] { "Id", "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[,]
                {
                    { 14, 1, 6, 2 },
                    { 27, 4, 6, 4 },
                    { 28, 5, 5, 4 },
                    { 29, 4, 7, 4 },
                    { 44, 10, 2, 6 },
                    { 55, 4, 10, 7 },
                    { 67, 4, 7, 9 },
                    { 77, 1, 7, 10 },
                    { 78, 7, 3, 10 },
                    { 79, 5, 6, 10 }
                });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 1, 1 });

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
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 10, 11 });

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
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 11, 4 });

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
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 1, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 2, 9, 1 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 3, 1 });

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
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 3, 3, 3 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 6, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 3, 8, 3 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 6, 3, 4 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 2, 6, 4 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 2, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 6, 3, 5 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 7, 6, 5 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 6, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 3, 8, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 5, 9, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 11, 6, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 1, 9, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 11, 11, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 8, 6, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 5, 1, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 7, 2, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 11, 2, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 3, 6, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 3, 1, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 4, 3, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 5, 6, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 3, 7, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 4, 3, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 1, 3, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 3, 1, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 1, 5, 8 });

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "Id", "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[,]
                {
                    { 3, 4, 3, 1 },
                    { 11, 4, 6, 2 },
                    { 12, 6, 7, 2 },
                    { 13, 7, 1, 2 },
                    { 21, 1, 2, 3 },
                    { 22, 1, 2, 4 },
                    { 23, 3, 2, 4 },
                    { 26, 6, 1, 4 },
                    { 34, 1, 5, 5 },
                    { 36, 3, 3, 6 },
                    { 42, 2, 1, 6 },
                    { 45, 3, 8, 7 },
                    { 53, 9, 5, 7 },
                    { 62, 2, 4, 9 },
                    { 63, 4, 5, 9 },
                    { 64, 5, 3, 9 },
                    { 65, 7, 8, 9 },
                    { 66, 1, 8, 9 },
                    { 68, 11, 3, 10 },
                    { 69, 9, 4, 10 },
                    { 70, 7, 7, 10 },
                    { 71, 4, 9, 10 },
                    { 72, 1, 10, 10 },
                    { 73, 3, 2, 10 },
                    { 74, 11, 9, 10 },
                    { 75, 3, 6, 10 },
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

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "GovernorCardId", "IsColonized", "PlanetId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 136, null, false, 52, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7523), null },
                    { 137, null, false, 52, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7523), null },
                    { 138, null, false, 52, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7524), null },
                    { 142, null, false, 56, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7538), null },
                    { 143, null, false, 56, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7538), null },
                    { 144, null, false, 56, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7539), null },
                    { 145, null, false, 57, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7543), null },
                    { 146, null, false, 57, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7544), null },
                    { 147, null, false, 57, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7544), null },
                    { 148, null, false, 58, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7548), null },
                    { 149, null, false, 58, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7548), null },
                    { 150, null, false, 58, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7548), null },
                    { 151, null, false, 59, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7553), null },
                    { 152, null, false, 59, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7553), null },
                    { 153, null, false, 59, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7553), null },
                    { 154, null, false, 60, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7562), null },
                    { 155, null, false, 60, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7579), null },
                    { 156, null, false, 60, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7580), null }
                });

            migrationBuilder.UpdateData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 1,
                column: "Img",
                value: "spaceship_test.jpg");

            migrationBuilder.UpdateData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 2,
                column: "Img",
                value: "spaceship_test.jpg");

            migrationBuilder.UpdateData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 3,
                column: "Img",
                value: "spaceship_test.jpg");

            migrationBuilder.UpdateData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 4,
                column: "Img",
                value: "spaceship_test.jpg");

            migrationBuilder.UpdateData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 5,
                column: "Img",
                value: "spaceship_test.jpg");

            migrationBuilder.UpdateData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 6,
                column: "Img",
                value: "spaceship_test.jpg");

            migrationBuilder.UpdateData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 7,
                column: "Img",
                value: "spaceship_test.jpg");

            migrationBuilder.UpdateData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 8,
                column: "Img",
                value: "spaceship_test.jpg");

            migrationBuilder.UpdateData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 9,
                column: "Img",
                value: "spaceship_test.jpg");

            migrationBuilder.UpdateData(
                table: "Ships",
                keyColumn: "Id",
                keyValue: 10,
                column: "Img",
                value: "spaceship_test.jpg");

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "GovernorCardId", "IsColonized", "PlanetId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 139, null, false, 53, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7527), null },
                    { 140, null, false, 53, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7528), null },
                    { 141, null, false, 53, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7528), null },
                    { 157, null, false, 62, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7588), null },
                    { 158, null, false, 62, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7588), null },
                    { 159, null, false, 62, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7589), null },
                    { 160, null, false, 63, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7593), null },
                    { 161, null, false, 63, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7593), null },
                    { 162, null, false, 63, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7594), null },
                    { 163, null, false, 64, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7599), null },
                    { 164, null, false, 64, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7599), null },
                    { 165, null, false, 64, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7599), null },
                    { 166, null, false, 65, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7603), null },
                    { 167, null, false, 65, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7603), null },
                    { 168, null, false, 65, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7604), null },
                    { 169, null, false, 66, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7610), null },
                    { 170, null, false, 66, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7610), null },
                    { 171, null, false, 66, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7610), null },
                    { 172, null, false, 68, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7618), null },
                    { 173, null, false, 68, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7619), null },
                    { 174, null, false, 68, new DateTime(2024, 10, 15, 7, 2, 48, 386, DateTimeKind.Utc).AddTicks(7619), null },
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 78);

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
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 13);

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
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 45);

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
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 62);

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

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 68);

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

            migrationBuilder.DropColumn(
                name: "Img",
                table: "Ships");

            migrationBuilder.AlterColumn<double>(
                name: "CoordinateY",
                table: "Planets",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "CoordinateX",
                table: "Planets",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "CoordinateY",
                table: "JumpGate",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "CoordinateX",
                table: "JumpGate",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "CoordinateY",
                table: "AsteroidField",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "CoordinateX",
                table: "AsteroidField",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 6.0, 1.0, 6 });

            migrationBuilder.UpdateData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 5.0, 3.0, 9 });

            migrationBuilder.UpdateData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 8.0, 7.0, 10 });

            migrationBuilder.InsertData(
                table: "AsteroidField",
                columns: new[] { "Id", "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[,]
                {
                    { 3, 7.0, 4.0, 1 },
                    { 11, 1.0, 8.0, 2 },
                    { 12, 6.0, 5.0, 2 },
                    { 13, 9.0, 3.0, 2 },
                    { 21, 3.0, 1.0, 4 },
                    { 22, 2.0, 2.0, 4 },
                    { 23, 1.0, 6.0, 4 },
                    { 26, 6.0, 5.0, 5 },
                    { 34, 8.0, 2.0, 6 },
                    { 36, 1.0, 9.0, 6 },
                    { 42, 6.0, 1.0, 7 },
                    { 45, 7.0, 2.0, 8 },
                    { 53, 1.0, 8.0, 9 },
                    { 62, 8.0, 10.0, 10 },
                    { 63, 11.0, 9.0, 10 }
                });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 7.0, 2.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 8.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 9.0, 7.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 3.0, 7.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 6.0, 7.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 9.0, 2.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 8.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 7.0, 4.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 8.0, 5.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 10.0, 8.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 4.0, 5.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 7.0, 7.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 1.0, 1.0, 2 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 4.0, 6.0, 2 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 8.0, 7.0, 2 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 6.0, 2.0, 2 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 2.0, 4.0, 2 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 3.0, 1.0, 2 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 3.0, 9.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 2.0, 2.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 3.0, 5.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 3.0, 7.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 5.0, 3.0, 4 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 3.0, 5.0, 4 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 1.0, 4.0, 4 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 6.0, 3.0, 5 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 2.0, 7.0, 5 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 5.0, 9.0, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 4.0, 3.0, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 4.0, 1.0, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 2.0, 6.0, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 6.0, 3.0, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 2.0, 2.0, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 8.0, 8.0, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 8.0, 6.0, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 9.0, 4.0, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 1.0, 1.0, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 3.0, 7.0, 9 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 5.0, 8.0, 9 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 8.0, 8.0, 9 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 6.0, 5.0, 9 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 1.0, 5.0, 9 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 4.0, 1.0, 9 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 3.0, 4.0, 9 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 5.0, 1.0, 10 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 8.0, 3.0, 10 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 5.0, 3.0, 10 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 10.0, 5.0, 10 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 3.0, 1.0, 10 });

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "Id", "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[,]
                {
                    { 14, 1.0, 5.0, 3 },
                    { 27, 4.0, 5.0, 6 },
                    { 28, 6.0, 6.0, 6 },
                    { 29, 2.0, 2.0, 6 },
                    { 44, 4.0, 4.0, 8 },
                    { 55, 4.0, 10.0, 10 }
                });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedAt",
                value: new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6663) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6664) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6664) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6671) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6671) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6681) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6681) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6682) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6686) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6686) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6687) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6701) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6701) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6702) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6706) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6706) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6706) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6712) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6713) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6713) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 14, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6724) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 14, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6724) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 14, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6724) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 15, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6729) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 15, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6730) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 15, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6730) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 16, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6735) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 16, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6735) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 16, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6736) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 17, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 17, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 17, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 18, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6748) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 18, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6748) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 18, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6749) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 19, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6759) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 19, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6759) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 19, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6759) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 20, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6763) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 20, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6763) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 20, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6764) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 24, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 24, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 24, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 25, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6780) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 25, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6781) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 25, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6781) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 27, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 27, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 27, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 28, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 28, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 28, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 29, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 29, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 29, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 30, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6805) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 30, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6805) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 30, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6812) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 31, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 31, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 31, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 32, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6825) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 32, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6825) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 32, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6825) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 33, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6829) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 33, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6830) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 33, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6830) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 37, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6842) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 37, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6842) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 37, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6842) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 38, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6848) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 38, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6848) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 38, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6849) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 39, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6853) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 39, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6853) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 39, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6854) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 40, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6858) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 40, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6858) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 40, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6859) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 41, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6868) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 41, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6868) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 41, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6869) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 43, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6877) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 43, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6877) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 43, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6877) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 44, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6883) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 44, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6883) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 44, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6883) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 46, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6893) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 46, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6893) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 46, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6893) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 47, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6897) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 47, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6897) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 47, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6898) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 48, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 48, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6907) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 48, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6907) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 49, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6912) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 49, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6912) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 49, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6913) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 50, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6919) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 50, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 50, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 51, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6924) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 51, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6924) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 51, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6924) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 52, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6929) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 52, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6929) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 52, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6929) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 55, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 55, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 55, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 56, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6945) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 56, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6946) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 56, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6946) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 57, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6951) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 57, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6951) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 57, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6951) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 58, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6956) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 58, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6956) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 58, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6956) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 59, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6967) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 59, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6967) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 59, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6968) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 60, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6971) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 60, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6972) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "PlanetId", "UpdatedAt" },
                values: new object[] { 60, new DateTime(2024, 10, 11, 15, 42, 51, 59, DateTimeKind.Utc).AddTicks(6972) });
        }
    }
}
