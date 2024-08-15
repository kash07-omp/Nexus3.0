using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nexus.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class _20240815_Researchs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Researches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Researches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StructureRequiredStructure",
                columns: table => new
                {
                    StructureId = table.Column<int>(type: "int", nullable: false),
                    RequiredStructureId = table.Column<int>(type: "int", nullable: false),
                    RequiredStructureLevel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StructureRequiredStructure", x => new { x.StructureId, x.RequiredStructureId });
                    table.ForeignKey(
                        name: "FK_StructureRequiredStructure_Structures_RequiredStructureId",
                        column: x => x.RequiredStructureId,
                        principalTable: "Structures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StructureRequiredStructure_Structures_StructureId",
                        column: x => x.StructureId,
                        principalTable: "Structures",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ResearchRequiredResearch",
                columns: table => new
                {
                    ResearchId = table.Column<int>(type: "int", nullable: false),
                    RequiredResearchId = table.Column<int>(type: "int", nullable: false),
                    ResearchId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResearchRequiredResearch", x => new { x.ResearchId, x.RequiredResearchId });
                    table.ForeignKey(
                        name: "FK_ResearchRequiredResearch_Researches_RequiredResearchId",
                        column: x => x.RequiredResearchId,
                        principalTable: "Researches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResearchRequiredResearch_Researches_ResearchId",
                        column: x => x.ResearchId,
                        principalTable: "Researches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ResearchRequiredResearch_Researches_ResearchId1",
                        column: x => x.ResearchId1,
                        principalTable: "Researches",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ResearchRequiredStructure",
                columns: table => new
                {
                    ResearchId = table.Column<int>(type: "int", nullable: false),
                    RequiredStructureId = table.Column<int>(type: "int", nullable: false),
                    RequiredStructureLevel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResearchRequiredStructure", x => new { x.ResearchId, x.RequiredStructureId });
                    table.ForeignKey(
                        name: "FK_ResearchRequiredStructure_Researches_ResearchId",
                        column: x => x.ResearchId,
                        principalTable: "Researches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResearchRequiredStructure_Structures_RequiredStructureId",
                        column: x => x.RequiredStructureId,
                        principalTable: "Structures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StructureRequiredResearch",
                columns: table => new
                {
                    StructureId = table.Column<int>(type: "int", nullable: false),
                    RequiredResearchId = table.Column<int>(type: "int", nullable: false),
                    ResearchId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StructureRequiredResearch", x => new { x.StructureId, x.RequiredResearchId });
                    table.ForeignKey(
                        name: "FK_StructureRequiredResearch_Researches_RequiredResearchId",
                        column: x => x.RequiredResearchId,
                        principalTable: "Researches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StructureRequiredResearch_Researches_ResearchId",
                        column: x => x.ResearchId,
                        principalTable: "Researches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StructureRequiredResearch_Structures_StructureId",
                        column: x => x.StructureId,
                        principalTable: "Structures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                keyValue: 13,
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
                value: 4);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 26,
                column: "SolarSystemId",
                value: 4);

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
                value: 6);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 40,
                column: "SolarSystemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 41,
                column: "SolarSystemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 42,
                column: "SolarSystemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 43,
                column: "SolarSystemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 44,
                column: "SolarSystemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 45,
                column: "SolarSystemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 46,
                column: "SolarSystemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 47,
                column: "SolarSystemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 48,
                column: "SolarSystemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 49,
                column: "SolarSystemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 50,
                column: "SolarSystemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 51,
                column: "SolarSystemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 52,
                column: "SolarSystemId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 53,
                column: "SolarSystemId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 54,
                column: "SolarSystemId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 55,
                column: "SolarSystemId",
                value: 8);

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "Id", "SolarSystemId" },
                values: new object[,]
                {
                    { 56, 8 },
                    { 57, 8 },
                    { 58, 8 },
                    { 59, 9 },
                    { 60, 9 },
                    { 61, 9 },
                    { 62, 9 },
                    { 63, 9 },
                    { 64, 10 },
                    { 65, 10 },
                    { 66, 10 },
                    { 67, 10 },
                    { 68, 10 },
                    { 69, 10 },
                    { 70, 10 },
                    { 71, 10 }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "IsColonized", "PlanetId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 166, false, 56, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 167, false, 56, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 168, false, 56, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 169, false, 57, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 170, false, 57, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 171, false, 57, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 172, false, 58, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 173, false, 58, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 174, false, 58, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 175, false, 59, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 176, false, 59, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 177, false, 59, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 178, false, 60, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 179, false, 60, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 180, false, 60, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 181, false, 61, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 182, false, 61, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 183, false, 61, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 184, false, 62, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 185, false, 62, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 186, false, 62, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 187, false, 63, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 188, false, 63, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 189, false, 63, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 190, false, 64, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 191, false, 64, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 192, false, 64, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 193, false, 65, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 194, false, 65, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 195, false, 65, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 196, false, 66, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 197, false, 66, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 198, false, 66, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 199, false, 67, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 200, false, 67, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 201, false, 67, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 202, false, 68, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 203, false, 68, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 204, false, 68, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 205, false, 69, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 206, false, 69, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 207, false, 69, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 208, false, 70, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 209, false, 70, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 210, false, 70, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 211, false, 71, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 212, false, 71, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 213, false, 71, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ResearchRequiredResearch_RequiredResearchId",
                table: "ResearchRequiredResearch",
                column: "RequiredResearchId");

            migrationBuilder.CreateIndex(
                name: "IX_ResearchRequiredResearch_ResearchId1",
                table: "ResearchRequiredResearch",
                column: "ResearchId1");

            migrationBuilder.CreateIndex(
                name: "IX_ResearchRequiredStructure_RequiredStructureId",
                table: "ResearchRequiredStructure",
                column: "RequiredStructureId");

            migrationBuilder.CreateIndex(
                name: "IX_StructureRequiredResearch_RequiredResearchId",
                table: "StructureRequiredResearch",
                column: "RequiredResearchId");

            migrationBuilder.CreateIndex(
                name: "IX_StructureRequiredResearch_ResearchId",
                table: "StructureRequiredResearch",
                column: "ResearchId");

            migrationBuilder.CreateIndex(
                name: "IX_StructureRequiredStructure_RequiredStructureId",
                table: "StructureRequiredStructure",
                column: "RequiredStructureId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResearchRequiredResearch");

            migrationBuilder.DropTable(
                name: "ResearchRequiredStructure");

            migrationBuilder.DropTable(
                name: "StructureRequiredResearch");

            migrationBuilder.DropTable(
                name: "StructureRequiredStructure");

            migrationBuilder.DropTable(
                name: "Researches");

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
                table: "Regions",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 213);

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

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 60);

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
                keyValue: 71);

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
                keyValue: 13,
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
                keyValue: 22,
                column: "SolarSystemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 23,
                column: "SolarSystemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 24,
                column: "SolarSystemId",
                value: 5);

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
                keyValue: 34,
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
                value: 8);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 48,
                column: "SolarSystemId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 49,
                column: "SolarSystemId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 50,
                column: "SolarSystemId",
                value: 9);

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
                value: 10);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 53,
                column: "SolarSystemId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 54,
                column: "SolarSystemId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 55,
                column: "SolarSystemId",
                value: 10);
        }
    }
}
