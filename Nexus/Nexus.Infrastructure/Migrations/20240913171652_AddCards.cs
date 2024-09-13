using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nexus.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddCards : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                keyValue: 51);

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
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 55);

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
                keyValue: 58);

            migrationBuilder.AddColumn<int>(
                name: "GovernorCardId",
                table: "Regions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CardType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CardBonuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    BonusType = table.Column<int>(type: "int", nullable: false),
                    Percentage = table.Column<int>(type: "int", nullable: false),
                    StructureId = table.Column<int>(type: "int", nullable: true),
                    CardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardBonuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardBonuses_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardBonuses_Structures_StructureId",
                        column: x => x.StructureId,
                        principalTable: "Structures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "CardType", "Description", "Name" },
                values: new object[,]
                {
                    { 1, 0, "A well-known governor focused on boosting production at all costs.", "Kily Gavin" },
                    { 2, 0, "An efficient governor known for reducing the time to complete projects.", "Faster Krate" }
                });

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
                value: 3);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 9,
                column: "SolarSystemId",
                value: 3);

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
                value: 4);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 14,
                column: "SolarSystemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 15,
                column: "SolarSystemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 16,
                column: "SolarSystemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 17,
                column: "SolarSystemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 18,
                column: "SolarSystemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 19,
                column: "SolarSystemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 20,
                column: "SolarSystemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 21,
                column: "SolarSystemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 22,
                column: "SolarSystemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 23,
                column: "SolarSystemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 24,
                column: "SolarSystemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 25,
                column: "SolarSystemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 26,
                column: "SolarSystemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 27,
                column: "SolarSystemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 28,
                column: "SolarSystemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 29,
                column: "SolarSystemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 30,
                column: "SolarSystemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 31,
                column: "SolarSystemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 32,
                column: "SolarSystemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 33,
                column: "SolarSystemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 34,
                column: "SolarSystemId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 35,
                column: "SolarSystemId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 36,
                column: "SolarSystemId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 37,
                column: "SolarSystemId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 38,
                column: "SolarSystemId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 39,
                column: "SolarSystemId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 40,
                column: "SolarSystemId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 41,
                column: "SolarSystemId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 42,
                column: "SolarSystemId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 43,
                column: "SolarSystemId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 44,
                column: "SolarSystemId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 45,
                column: "SolarSystemId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 46,
                column: "SolarSystemId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 47,
                column: "SolarSystemId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 48,
                column: "SolarSystemId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 1,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 2,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 3,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 4,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 5,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 6,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 7,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 8,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 9,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 10,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 11,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 12,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 13,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 14,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 15,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 16,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 17,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 18,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 19,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 20,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 21,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 22,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 23,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 24,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 25,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 26,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 27,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 28,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 29,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 30,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 31,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 32,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 33,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 34,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 35,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 36,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 37,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 38,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 39,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 40,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 41,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 42,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 43,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 44,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 45,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 46,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 47,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 48,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 49,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 50,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 51,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 52,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 53,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 54,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 55,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 56,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 57,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 58,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 59,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 60,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 61,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 62,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 63,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 64,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 65,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 66,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 67,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 68,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 69,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 70,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 71,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 72,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 73,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 74,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 75,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 76,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 77,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 78,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 79,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 80,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 81,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 82,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 83,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 84,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 85,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 86,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 87,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 88,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 89,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 90,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 91,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 92,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 93,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 94,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 95,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 96,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 97,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 98,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 99,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 100,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 101,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 102,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 103,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 104,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 105,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 106,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 107,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 108,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 109,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 110,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 111,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 112,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 113,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 114,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 115,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 116,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 117,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 118,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 119,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 120,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 121,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 122,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 123,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 124,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 125,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 126,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 127,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 128,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 129,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 130,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 131,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 132,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 133,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 134,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 135,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 136,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 137,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 138,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 139,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 140,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 141,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 142,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 143,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 144,
                column: "GovernorCardId",
                value: null);

            migrationBuilder.InsertData(
                table: "CardBonuses",
                columns: new[] { "Id", "BonusType", "CardId", "Description", "Percentage", "StructureId", "Title" },
                values: new object[,]
                {
                    { 1, 1, 1, "Increases the production output of the mineral mine by 20%.", 20, 2, "Production Boost: Minerals" },
                    { 2, 1, 1, "Increases the production output of the microchip factory by 15%.", 15, 3, "Production Boost: Microchips" },
                    { 3, 2, 1, "Increases energy consumption of the mineral mine by 10%.", 10, 2, "Increased Energy Consumption" },
                    { 4, 0, 2, "Reduces construction time for all structures in the region by 30%.", -30, null, "Construction Time Reduction" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Regions_GovernorCardId",
                table: "Regions",
                column: "GovernorCardId");

            migrationBuilder.CreateIndex(
                name: "IX_CardBonuses_CardId",
                table: "CardBonuses",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_CardBonuses_StructureId",
                table: "CardBonuses",
                column: "StructureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Regions_Cards_GovernorCardId",
                table: "Regions",
                column: "GovernorCardId",
                principalTable: "Cards",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Regions_Cards_GovernorCardId",
                table: "Regions");

            migrationBuilder.DropTable(
                name: "CardBonuses");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropIndex(
                name: "IX_Regions_GovernorCardId",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "GovernorCardId",
                table: "Regions");

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
                keyValue: 9,
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
                keyValue: 30,
                column: "SolarSystemId",
                value: 5);

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
                keyValue: 36,
                column: "SolarSystemId",
                value: 6);

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
                keyValue: 39,
                column: "SolarSystemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 40,
                column: "SolarSystemId",
                value: 7);

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
                value: 8);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 45,
                column: "SolarSystemId",
                value: 8);

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
                value: 9);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 48,
                column: "SolarSystemId",
                value: 9);

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "Id", "SolarSystemId" },
                values: new object[,]
                {
                    { 49, 9 },
                    { 50, 9 },
                    { 51, 9 },
                    { 52, 9 },
                    { 53, 9 },
                    { 54, 10 },
                    { 55, 10 },
                    { 56, 10 },
                    { 57, 10 },
                    { 58, 10 }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "IsColonized", "PlanetId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 145, false, 49, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 146, false, 49, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 147, false, 49, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 148, false, 50, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 149, false, 50, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 150, false, 50, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 151, false, 51, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 152, false, 51, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 153, false, 51, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 154, false, 52, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 155, false, 52, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 156, false, 52, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 157, false, 53, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 158, false, 53, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 159, false, 53, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 160, false, 54, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 161, false, 54, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 162, false, 54, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 163, false, 55, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 164, false, 55, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 165, false, 55, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 166, false, 56, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 167, false, 56, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 168, false, 56, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 169, false, 57, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 170, false, 57, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 171, false, 57, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 172, false, 58, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 173, false, 58, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 174, false, 58, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });
        }
    }
}
