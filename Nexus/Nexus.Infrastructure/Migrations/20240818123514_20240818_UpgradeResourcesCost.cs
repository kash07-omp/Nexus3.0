using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nexus.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class _20240818_UpgradeResourcesCost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BaseChips",
                table: "Structures",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BaseCredits",
                table: "Structures",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BaseEnergy",
                table: "Structures",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BaseHydrogen",
                table: "Structures",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BaseMinerales",
                table: "Structures",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "CanLevelUp",
                table: "Structures",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Mines",
                keyColumn: "Id",
                keyValue: (short)2,
                column: "GainMultiplier",
                value: 170);

            migrationBuilder.UpdateData(
                table: "Mines",
                keyColumn: "Id",
                keyValue: (short)3,
                column: "GainMultiplier",
                value: 140);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 5,
                column: "SolarSystemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 6,
                column: "SolarSystemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 7,
                column: "SolarSystemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 8,
                column: "SolarSystemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 10,
                column: "SolarSystemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 11,
                column: "SolarSystemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 12,
                column: "SolarSystemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 13,
                column: "SolarSystemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 18,
                column: "SolarSystemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 31,
                column: "SolarSystemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 32,
                column: "SolarSystemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 33,
                column: "SolarSystemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 35,
                column: "SolarSystemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 36,
                column: "SolarSystemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 41,
                column: "SolarSystemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 42,
                column: "SolarSystemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 43,
                column: "SolarSystemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 44,
                column: "SolarSystemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 46,
                column: "SolarSystemId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 47,
                column: "SolarSystemId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 51,
                column: "SolarSystemId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 52,
                column: "SolarSystemId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 53,
                column: "SolarSystemId",
                value: 9);

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "Id", "SolarSystemId" },
                values: new object[] { 59, 10 });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Code", "Description", "Name" },
                values: new object[] { 7, "ENERGY", "The total energy of the region. This energy powers all the region buildings.", "Energy" });

            migrationBuilder.UpdateData(
                table: "Structures",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BaseChips", "BaseCredits", "BaseEnergy", "BaseHydrogen", "BaseMinerales", "CanLevelUp" },
                values: new object[] { 100, 1000, 0, 50, 500, true });

            migrationBuilder.UpdateData(
                table: "Structures",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BaseChips", "BaseCredits", "BaseEnergy", "BaseHydrogen", "BaseMinerales", "CanLevelUp" },
                values: new object[] { 100, 1000, 0, 50, 500, true });

            migrationBuilder.UpdateData(
                table: "Structures",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BaseChips", "BaseCredits", "BaseEnergy", "BaseHydrogen", "BaseMinerales", "CanLevelUp" },
                values: new object[] { 100, 1000, 0, 50, 500, true });

            migrationBuilder.UpdateData(
                table: "Structures",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BaseChips", "BaseCredits", "BaseEnergy", "BaseHydrogen", "BaseMinerales", "CanLevelUp" },
                values: new object[] { 100, 1000, 0, 50, 500, false });

            migrationBuilder.UpdateData(
                table: "Structures",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BaseChips", "BaseCredits", "BaseEnergy", "BaseHydrogen", "BaseMinerales", "CanLevelUp" },
                values: new object[] { 100, 1000, 0, 50, 500, false });

            migrationBuilder.UpdateData(
                table: "Structures",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BaseChips", "BaseCredits", "BaseEnergy", "BaseHydrogen", "BaseMinerales", "CanLevelUp" },
                values: new object[] { 100, 1000, 0, 50, 500, false });

            migrationBuilder.UpdateData(
                table: "Structures",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BaseChips", "BaseCredits", "BaseEnergy", "BaseHydrogen", "BaseMinerales", "CanLevelUp" },
                values: new object[] { 100, 1000, 0, 50, 500, false });

            migrationBuilder.UpdateData(
                table: "Structures",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BaseChips", "BaseCredits", "BaseEnergy", "BaseHydrogen", "BaseMinerales", "CanLevelUp" },
                values: new object[] { 100, 1000, 0, 50, 500, false });

            migrationBuilder.UpdateData(
                table: "Structures",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BaseChips", "BaseCredits", "BaseEnergy", "BaseHydrogen", "BaseMinerales", "CanLevelUp" },
                values: new object[] { 100, 1000, 0, 50, 500, false });

            migrationBuilder.UpdateData(
                table: "Structures",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BaseChips", "BaseCredits", "BaseEnergy", "BaseHydrogen", "BaseMinerales", "CanLevelUp" },
                values: new object[] { 100, 1000, 0, 50, 500, false });

            migrationBuilder.UpdateData(
                table: "Structures",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BaseChips", "BaseCredits", "BaseEnergy", "BaseHydrogen", "BaseMinerales", "CanLevelUp" },
                values: new object[] { 100, 1000, 0, 50, 500, false });

            migrationBuilder.UpdateData(
                table: "Structures",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BaseChips", "BaseCredits", "BaseEnergy", "BaseHydrogen", "BaseMinerales", "CanLevelUp" },
                values: new object[] { 100, 1000, 0, 50, 500, false });

            migrationBuilder.UpdateData(
                table: "Structures",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BaseChips", "BaseCredits", "BaseEnergy", "BaseHydrogen", "BaseMinerales", "CanLevelUp" },
                values: new object[] { 100, 1000, 0, 50, 500, true });

            migrationBuilder.UpdateData(
                table: "Structures",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BaseChips", "BaseCredits", "BaseEnergy", "BaseHydrogen", "BaseMinerales", "CanLevelUp" },
                values: new object[] { 100, 1000, 0, 50, 500, false });

            migrationBuilder.InsertData(
                table: "Structures",
                columns: new[] { "Id", "BaseChips", "BaseCredits", "BaseEnergy", "BaseHydrogen", "BaseMinerales", "CanLevelUp", "Description", "DistrictId", "MineId", "Name" },
                values: new object[] { 15, 100, 1000, 0, 50, 500, true, "Provides energy to the region. Each level adds more energy points.", 2, null, "Campo de paneles solares" });

            migrationBuilder.InsertData(
                table: "Mines",
                columns: new[] { "Id", "Code", "GainMultiplier", "ResourceId" },
                values: new object[,]
                {
                    { (short)4, "SOLAR_MINE", 170, 7 },
                    { (short)5, "REACTOR_MINE", 210, 7 }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "IsColonized", "PlanetId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 175, false, 59, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 176, false, 59, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 177, false, 59, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Mines",
                keyColumn: "Id",
                keyValue: (short)4);

            migrationBuilder.DeleteData(
                table: "Mines",
                keyColumn: "Id",
                keyValue: (short)5);

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
                table: "Structures",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DropColumn(
                name: "BaseChips",
                table: "Structures");

            migrationBuilder.DropColumn(
                name: "BaseCredits",
                table: "Structures");

            migrationBuilder.DropColumn(
                name: "BaseEnergy",
                table: "Structures");

            migrationBuilder.DropColumn(
                name: "BaseHydrogen",
                table: "Structures");

            migrationBuilder.DropColumn(
                name: "BaseMinerales",
                table: "Structures");

            migrationBuilder.DropColumn(
                name: "CanLevelUp",
                table: "Structures");

            migrationBuilder.UpdateData(
                table: "Mines",
                keyColumn: "Id",
                keyValue: (short)2,
                column: "GainMultiplier",
                value: 200);

            migrationBuilder.UpdateData(
                table: "Mines",
                keyColumn: "Id",
                keyValue: (short)3,
                column: "GainMultiplier",
                value: 135);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 5,
                column: "SolarSystemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 6,
                column: "SolarSystemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 7,
                column: "SolarSystemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 8,
                column: "SolarSystemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 10,
                column: "SolarSystemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 11,
                column: "SolarSystemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 12,
                column: "SolarSystemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 13,
                column: "SolarSystemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 18,
                column: "SolarSystemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 31,
                column: "SolarSystemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 32,
                column: "SolarSystemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 33,
                column: "SolarSystemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 35,
                column: "SolarSystemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 36,
                column: "SolarSystemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 41,
                column: "SolarSystemId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 42,
                column: "SolarSystemId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 43,
                column: "SolarSystemId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 44,
                column: "SolarSystemId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 46,
                column: "SolarSystemId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 47,
                column: "SolarSystemId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 51,
                column: "SolarSystemId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 52,
                column: "SolarSystemId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 53,
                column: "SolarSystemId",
                value: 10);
        }
    }
}
