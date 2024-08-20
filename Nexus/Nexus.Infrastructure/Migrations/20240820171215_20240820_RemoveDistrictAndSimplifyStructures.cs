using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nexus.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class _20240820_RemoveDistrictAndSimplifyStructures : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Structures_Districts_DistrictId",
                table: "Structures");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropIndex(
                name: "IX_Structures_DistrictId",
                table: "Structures");

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
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Structures",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Structures",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Structures",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DropColumn(
                name: "DistrictId",
                table: "Structures");

            migrationBuilder.UpdateData(
                table: "Mines",
                keyColumn: "Id",
                keyValue: (short)4,
                column: "Code",
                value: "ENERGY_GENERATOR");

            migrationBuilder.UpdateData(
                table: "Mines",
                keyColumn: "Id",
                keyValue: (short)5,
                column: "Code",
                value: "NUCLEAR_REACTOR");

            migrationBuilder.InsertData(
                table: "Mines",
                columns: new[] { "Id", "Code", "GainMultiplier", "ResourceId" },
                values: new object[] { (short)6, "FOOD_FARM", 150, 4 });

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 9,
                column: "SolarSystemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 14,
                column: "SolarSystemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 15,
                column: "SolarSystemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 16,
                column: "SolarSystemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 17,
                column: "SolarSystemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 18,
                column: "SolarSystemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 19,
                column: "SolarSystemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 20,
                column: "SolarSystemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 21,
                column: "SolarSystemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 22,
                column: "SolarSystemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 23,
                column: "SolarSystemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 24,
                column: "SolarSystemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 25,
                column: "SolarSystemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 26,
                column: "SolarSystemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 27,
                column: "SolarSystemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 28,
                column: "SolarSystemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 29,
                column: "SolarSystemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 34,
                column: "SolarSystemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 35,
                column: "SolarSystemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 37,
                column: "SolarSystemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 38,
                column: "SolarSystemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 44,
                column: "SolarSystemId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 47,
                column: "SolarSystemId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Structures",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CanLevelUp", "Description", "MineId", "Name" },
                values: new object[] { false, "The central administrative building where laws are enacted and the region is governed.", null, "City Hall" });

            migrationBuilder.UpdateData(
                table: "Structures",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "MineId", "Name" },
                values: new object[] { "A mine that extracts essential minerals from the planet’s crust.", (short)1, "Raw Material Mine" });

            migrationBuilder.UpdateData(
                table: "Structures",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "MineId", "Name" },
                values: new object[] { "A specialized facility for producing advanced microchips needed for high-tech devices.", (short)2, "Microchip Factory" });

            migrationBuilder.UpdateData(
                table: "Structures",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CanLevelUp", "Description", "MineId", "Name" },
                values: new object[] { true, "A facility that extracts hydrogen, used as fuel for spacecraft and energy production.", (short)3, "Hydrogen Mine" });

            migrationBuilder.UpdateData(
                table: "Structures",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CanLevelUp", "Description", "MineId", "Name" },
                values: new object[] { true, "A generator that produces energy to power the region's infrastructure.", (short)4, "Energy Generator" });

            migrationBuilder.UpdateData(
                table: "Structures",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CanLevelUp", "Description", "MineId", "Name" },
                values: new object[] { true, "A powerful reactor that generates large amounts of energy for the region.", (short)5, "Nuclear Reactor" });

            migrationBuilder.UpdateData(
                table: "Structures",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CanLevelUp", "Description", "MineId", "Name" },
                values: new object[] { true, "Fields dedicated to agriculture, producing food to sustain the population.", (short)6, "Farmland" });

            migrationBuilder.UpdateData(
                table: "Structures",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CanLevelUp", "Description", "Name" },
                values: new object[] { true, "Housing complexes that provide homes for the population, increasing happiness.", "Residential Area" });

            migrationBuilder.UpdateData(
                table: "Structures",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Name" },
                values: new object[] { "A facility that allows for the recruitment and maintenance of spacecraft.", "Spaceport" });

            migrationBuilder.UpdateData(
                table: "Structures",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Name" },
                values: new object[] { "A military facility where ground troops are recruited and trained.", "Barracks" });

            migrationBuilder.UpdateData(
                table: "Structures",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Name" },
                values: new object[] { "A hub for scientific research, unlocking new technologies for the region.", "Research Center" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Mines",
                keyColumn: "Id",
                keyValue: (short)6);

            migrationBuilder.AddColumn<int>(
                name: "DistrictId",
                table: "Structures",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Manages the population and administrative functions of the region.", "Civil District" },
                    { 2, "Handles the production of resources in the region.", "Industrial District" }
                });

            migrationBuilder.UpdateData(
                table: "Mines",
                keyColumn: "Id",
                keyValue: (short)4,
                column: "Code",
                value: "SOLAR_MINE");

            migrationBuilder.UpdateData(
                table: "Mines",
                keyColumn: "Id",
                keyValue: (short)5,
                column: "Code",
                value: "REACTOR_MINE");

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 9,
                column: "SolarSystemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 14,
                column: "SolarSystemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 15,
                column: "SolarSystemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 16,
                column: "SolarSystemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 17,
                column: "SolarSystemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 18,
                column: "SolarSystemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 19,
                column: "SolarSystemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 20,
                column: "SolarSystemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 21,
                column: "SolarSystemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 22,
                column: "SolarSystemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 23,
                column: "SolarSystemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 24,
                column: "SolarSystemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 25,
                column: "SolarSystemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 26,
                column: "SolarSystemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 27,
                column: "SolarSystemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 28,
                column: "SolarSystemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 29,
                column: "SolarSystemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 34,
                column: "SolarSystemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 35,
                column: "SolarSystemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 37,
                column: "SolarSystemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 38,
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
                keyValue: 47,
                column: "SolarSystemId",
                value: 8);

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "Id", "SolarSystemId" },
                values: new object[] { 59, 10 });

            migrationBuilder.UpdateData(
                table: "Structures",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CanLevelUp", "Description", "DistrictId", "MineId", "Name" },
                values: new object[] { true, "Extracts minerals from the planetary crust.", 2, (short)1, "Mina de Minerales" });

            migrationBuilder.UpdateData(
                table: "Structures",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "DistrictId", "MineId", "Name" },
                values: new object[] { "Produces microchips necessary for advanced technology.", 2, (short)2, "Fábrica de Microchips" });

            migrationBuilder.UpdateData(
                table: "Structures",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "DistrictId", "MineId", "Name" },
                values: new object[] { "Extracts hydrogen, used as fuel for ships and energy.", 2, (short)3, "Mina de Hidrógeno" });

            migrationBuilder.UpdateData(
                table: "Structures",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CanLevelUp", "Description", "DistrictId", "MineId", "Name" },
                values: new object[] { false, "Improves work management in the mineral mine, increasing efficiency by 10%.", 2, null, "Centro de gestión del trabajo" });

            migrationBuilder.UpdateData(
                table: "Structures",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CanLevelUp", "Description", "DistrictId", "MineId", "Name" },
                values: new object[] { false, "Central hub of the city where laws are enacted and the region is administered.", 1, null, "Ayuntamiento" });

            migrationBuilder.UpdateData(
                table: "Structures",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CanLevelUp", "Description", "DistrictId", "MineId", "Name" },
                values: new object[] { false, "A network of hive buildings where the majority of your population lives.", 1, null, "Zona residencial" });

            migrationBuilder.UpdateData(
                table: "Structures",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CanLevelUp", "Description", "DistrictId", "MineId", "Name" },
                values: new object[] { false, "Bureaucrats work here to collect taxes from citizens.", 1, null, "Sede de Hacienda" });

            migrationBuilder.UpdateData(
                table: "Structures",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CanLevelUp", "Description", "DistrictId", "Name" },
                values: new object[] { false, "Protects citizens from disease and heals troops.", 1, "Centro médico" });

            migrationBuilder.UpdateData(
                table: "Structures",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "DistrictId", "Name" },
                values: new object[] { "Combines biotechnology and robotics to heal patients using nanobots.", 1, "Centro de medicina avanzada" });

            migrationBuilder.UpdateData(
                table: "Structures",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "DistrictId", "Name" },
                values: new object[] { "Facilitates drainage and improves regional sanitation.", 1, "Sistema de alcantarillado" });

            migrationBuilder.UpdateData(
                table: "Structures",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "DistrictId", "Name" },
                values: new object[] { "Heavy industry minds work here to improve microchip production by 10%.", 2, "Departamento de I+D" });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "IsColonized", "PlanetId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 175, false, 59, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 176, false, 59, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 177, false, 59, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Structures",
                columns: new[] { "Id", "BaseChips", "BaseCredits", "BaseEnergy", "BaseHydrogen", "BaseMinerales", "CanLevelUp", "Description", "DistrictId", "MineId", "Name" },
                values: new object[,]
                {
                    { 12, 100, 1000, 0, 50, 500, false, "Facilitates hydrogen processing, increasing extraction efficiency by 10%.", 2, null, "Red de tuberías de hidrógeno" },
                    { 13, 100, 1000, 0, 50, 500, true, "Provides energy to the region. Each level adds more energy points.", 2, null, "Reactor nuclear" },
                    { 14, 100, 1000, 0, 50, 500, false, "Modern assembly techniques and AI enable the construction of robots for work, increasing construction speed by 5%.", 2, null, "Fábrica de autómatas" },
                    { 15, 100, 1000, 0, 50, 500, true, "Provides energy to the region. Each level adds more energy points.", 2, null, "Campo de paneles solares" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Structures_DistrictId",
                table: "Structures",
                column: "DistrictId");

            migrationBuilder.AddForeignKey(
                name: "FK_Structures_Districts_DistrictId",
                table: "Structures",
                column: "DistrictId",
                principalTable: "Districts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
