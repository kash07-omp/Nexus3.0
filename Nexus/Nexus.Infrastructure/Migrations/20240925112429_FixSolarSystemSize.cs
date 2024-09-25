using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nexus.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixSolarSystemSize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 50);

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
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 12);

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
                keyValue: 61);

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
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 70);

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

            migrationBuilder.UpdateData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 1.0, 2.0, 2 });

            migrationBuilder.UpdateData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 3.0, 2.0, 2 });

            migrationBuilder.UpdateData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 2.0, 6.0, 8 });

            migrationBuilder.UpdateData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 1.0, 6.0, 9 });

            migrationBuilder.InsertData(
                table: "AsteroidField",
                columns: new[] { "Id", "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[,]
                {
                    { 12, 4.0, 7.0, 2 },
                    { 28, 4.0, 1.0, 5 },
                    { 29, 4.0, 3.0, 5 },
                    { 36, 1.0, 6.0, 6 },
                    { 37, 10.0, 8.0, 6 },
                    { 38, 3.0, 5.0, 6 },
                    { 45, 6.0, 11.0, 7 },
                    { 46, 10.0, 9.0, 7 },
                    { 47, 5.0, 10.0, 7 },
                    { 54, 5.0, 2.0, 8 },
                    { 61, 4.0, 2.0, 9 },
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
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 6.0, 3.0 });

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
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 2.0, 5.0 });

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
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 3.0, 4.0 });

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
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 8.0, 3.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 6.0, 9.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 6,
                column: "CoordinateY",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 1.0, 6.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 4.0, 5.0, 2 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 2.0, 5.0, 3 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CoordinateY", "SolarSystemId" },
                values: new object[] { 7.0, 3 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 6.0, 8.0, 3 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 11.0, 2.0, 3 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 6.0, 10.0, 3 });

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
                keyValue: 23,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 5.0, 5.0, 4 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CoordinateX", "SolarSystemId" },
                values: new object[] { 3.0, 4 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CoordinateX", "SolarSystemId" },
                values: new object[] { 4.0, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 7.0, 4.0, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 8.0, 11.0, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 11.0, 10.0, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 5.0, 3.0, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 9.0, 7.0, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 7.0, 9.0, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 7.0, 1.0, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 10.0, 2.0, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 1.0, 1.0, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 4.0, 10.0, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 10.0, 1.0, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 2.0, 11.0, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CoordinateX", "SolarSystemId" },
                values: new object[] { 5.0, 9 });

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
                keyValue: 64,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 2.0, 7.0, 10 });

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "Id", "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[,]
                {
                    { 9, 7.0, 5.0, 2 },
                    { 18, 6.0, 6.0, 3 },
                    { 19, 1.0, 11.0, 3 },
                    { 20, 2.0, 1.0, 3 },
                    { 25, 4.0, 5.0, 5 },
                    { 26, 7.0, 3.0, 5 },
                    { 27, 7.0, 6.0, 5 },
                    { 31, 2.0, 8.0, 6 },
                    { 32, 10.0, 1.0, 6 },
                    { 40, 8.0, 11.0, 7 },
                    { 49, 7.0, 5.0, 8 },
                    { 50, 3.0, 8.0, 8 },
                    { 56, 7.0, 3.0, 9 },
                    { 57, 6.0, 1.0, 9 },
                    { 63, 4.0, 2.0, 10 }
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 12);

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
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 50);

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
                keyValue: 63);

            migrationBuilder.UpdateData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 6.0, 1.0, 1 });

            migrationBuilder.UpdateData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 11.0, 5.0, 1 });

            migrationBuilder.UpdateData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 5.0, 3.0, 7 });

            migrationBuilder.UpdateData(
                table: "AsteroidField",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 4.0, 3.0, 8 });

            migrationBuilder.InsertData(
                table: "AsteroidField",
                columns: new[] { "Id", "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[,]
                {
                    { 9, 10.0, 8.0, 1 },
                    { 18, 4.0, 11.0, 2 },
                    { 19, 3.0, 2.0, 2 },
                    { 20, 6.0, 11.0, 2 },
                    { 25, 2.0, 4.0, 3 },
                    { 26, 2.0, 7.0, 3 },
                    { 27, 3.0, 7.0, 3 },
                    { 31, 1.0, 7.0, 4 },
                    { 32, 4.0, 3.0, 4 },
                    { 40, 4.0, 9.0, 5 },
                    { 49, 11.0, 8.0, 6 },
                    { 50, 2.0, 4.0, 6 },
                    { 56, 4.0, 4.0, 7 },
                    { 57, 2.0, 1.0, 7 },
                    { 63, 4.0, 7.0, 8 },
                    { 71, 2.0, 11.0, 9 }
                });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 9.0, 7.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 9.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 6.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 7.0, 6.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 11.0, 10.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 2.0, 11.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 1.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 3.0, 2.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 11.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "JumpGate",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 6.0, 9.0 });

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
                values: new object[] { 4.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 3.0, 8.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 1.0, 10.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 2.0, 6.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 6,
                column: "CoordinateY",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CoordinateX", "CoordinateY" },
                values: new object[] { 4.0, 10.0 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 1.0, 8.0, 1 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 1.0, 11.0, 2 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CoordinateY", "SolarSystemId" },
                values: new object[] { 9.0, 2 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 11.0, 11.0, 2 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 1.0, 8.0, 2 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 7.0, 3.0, 2 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 5.0, 7.0, 3 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 6.0, 3.0, 3 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 7.0, 6.0, 3 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CoordinateX", "SolarSystemId" },
                values: new object[] { 4.0, 3 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CoordinateX", "SolarSystemId" },
                values: new object[] { 2.0, 4 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 3.0, 1.0, 5 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 4.0, 7.0, 5 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 2.0, 7.0, 5 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 7.0, 7.0, 5 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 5.0, 8.0, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 8.0, 7.0, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 9.0, 9.0, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 3.0, 7.0, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 10.0, 6.0, 6 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 2.0, 4.0, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 7.0, 2.0, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 1.0, 7.0, 7 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CoordinateX", "SolarSystemId" },
                values: new object[] { 2.0, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 6.0, 7.0, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 6.0, 2.0, 8 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[] { 6.0, 3.0, 9 });

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "Id", "CoordinateX", "CoordinateY", "SolarSystemId" },
                values: new object[,]
                {
                    { 12, 3.0, 6.0, 2 },
                    { 28, 3.0, 6.0, 4 },
                    { 29, 5.0, 5.0, 4 },
                    { 36, 1.0, 4.0, 5 },
                    { 37, 3.0, 4.0, 5 },
                    { 38, 11.0, 8.0, 5 },
                    { 45, 6.0, 5.0, 6 },
                    { 46, 1.0, 6.0, 6 },
                    { 47, 6.0, 3.0, 6 },
                    { 54, 6.0, 6.0, 7 },
                    { 61, 7.0, 5.0, 8 },
                    { 65, 3.0, 6.0, 9 },
                    { 66, 10.0, 11.0, 9 },
                    { 67, 8.0, 2.0, 9 },
                    { 68, 9.0, 7.0, 9 },
                    { 69, 6.0, 1.0, 9 },
                    { 70, 11.0, 9.0, 9 },
                    { 72, 1.0, 7.0, 10 },
                    { 73, 1.0, 3.0, 10 },
                    { 74, 5.0, 1.0, 10 },
                    { 75, 2.0, 1.0, 10 }
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
        }
    }
}
