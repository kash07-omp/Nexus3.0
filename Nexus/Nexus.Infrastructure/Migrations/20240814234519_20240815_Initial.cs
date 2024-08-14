using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nexus.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class _20240815_Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Resources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resources", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SolarSystems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolarSystems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mines",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GainMultiplier = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ResourceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mines_Resources_ResourceId",
                        column: x => x.ResourceId,
                        principalTable: "Resources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Planets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SolarSystemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Planets_SolarSystems_SolarSystemId",
                        column: x => x.SolarSystemId,
                        principalTable: "SolarSystems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Structures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    MineId = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Structures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Structures_Mines_MineId",
                        column: x => x.MineId,
                        principalTable: "Mines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsColonized = table.Column<bool>(type: "bit", nullable: false),
                    PlanetId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Regions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Regions_Planets_PlanetId",
                        column: x => x.PlanetId,
                        principalTable: "Planets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegionStructures",
                columns: table => new
                {
                    StructureId = table.Column<int>(type: "int", nullable: false),
                    RegionId = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegionStructures", x => new { x.StructureId, x.RegionId });
                    table.ForeignKey(
                        name: "FK_RegionStructures_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegionStructures_Structures_StructureId",
                        column: x => x.StructureId,
                        principalTable: "Structures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Code", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "MINERALS", "Minerals extracted from the planetary crust. They are the most abundant resource and are mainly used for the creation of structures and ships.", "Minerals" },
                    { 2, "MICROCHIPS", "Technological materials designed and created with high technology. They are used to a lesser extent than minerals.", "Microchips" },
                    { 3, "HYDROGEN", "The main fuel for spaceships and is needed in smaller amounts by buildings and ships.", "Hydrogen" },
                    { 4, "FOOD", "Represents the food supplies. They are necessary to keep the population alive.", "Food" },
                    { 5, "POPULATION", "The number of inhabitants in each region.", "Population" },
                    { 6, "CREDITS", "The total money of the empire, obtained from trade treaties, taxes, and conquests. Credits are used to recruit troops, research, and close trade agreements.", "Credits" }
                });

            migrationBuilder.InsertData(
                table: "SolarSystems",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Solar System 1" },
                    { 2, "Solar System 2" },
                    { 3, "Solar System 3" },
                    { 4, "Solar System 4" },
                    { 5, "Solar System 5" },
                    { 6, "Solar System 6" },
                    { 7, "Solar System 7" },
                    { 8, "Solar System 8" },
                    { 9, "Solar System 9" },
                    { 10, "Solar System 10" }
                });

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "Id", "SolarSystemId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 1 },
                    { 5, 1 },
                    { 6, 1 },
                    { 7, 1 },
                    { 8, 1 },
                    { 9, 1 },
                    { 10, 2 },
                    { 11, 2 },
                    { 12, 2 },
                    { 13, 3 },
                    { 14, 3 },
                    { 15, 3 },
                    { 16, 4 },
                    { 17, 4 },
                    { 18, 4 },
                    { 19, 4 },
                    { 20, 4 },
                    { 21, 4 },
                    { 22, 4 },
                    { 23, 5 },
                    { 24, 5 },
                    { 25, 5 },
                    { 26, 5 },
                    { 27, 5 },
                    { 28, 5 },
                    { 29, 5 },
                    { 30, 5 },
                    { 31, 6 },
                    { 32, 6 },
                    { 33, 6 },
                    { 34, 6 },
                    { 35, 6 },
                    { 36, 7 },
                    { 37, 7 },
                    { 38, 7 },
                    { 39, 7 },
                    { 40, 8 },
                    { 41, 8 },
                    { 42, 8 },
                    { 43, 8 },
                    { 44, 8 },
                    { 45, 8 },
                    { 46, 8 },
                    { 47, 8 },
                    { 48, 8 },
                    { 49, 9 },
                    { 50, 9 },
                    { 51, 9 },
                    { 52, 9 },
                    { 53, 9 },
                    { 54, 9 },
                    { 55, 9 },
                    { 56, 9 },
                    { 57, 10 },
                    { 58, 10 },
                    { 59, 10 },
                    { 60, 10 }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "IsColonized", "PlanetId", "UserId" },
                values: new object[,]
                {
                    { 1, false, 1, null },
                    { 2, false, 1, null },
                    { 3, false, 1, null },
                    { 4, false, 2, null },
                    { 5, false, 2, null },
                    { 6, false, 2, null },
                    { 7, false, 3, null },
                    { 8, false, 3, null },
                    { 9, false, 3, null },
                    { 10, false, 4, null },
                    { 11, false, 4, null },
                    { 12, false, 4, null },
                    { 13, false, 5, null },
                    { 14, false, 5, null },
                    { 15, false, 5, null },
                    { 16, false, 6, null },
                    { 17, false, 6, null },
                    { 18, false, 6, null },
                    { 19, false, 7, null },
                    { 20, false, 7, null },
                    { 21, false, 7, null },
                    { 22, false, 8, null },
                    { 23, false, 8, null },
                    { 24, false, 8, null },
                    { 25, false, 9, null },
                    { 26, false, 9, null },
                    { 27, false, 9, null },
                    { 28, false, 10, null },
                    { 29, false, 10, null },
                    { 30, false, 10, null },
                    { 31, false, 11, null },
                    { 32, false, 11, null },
                    { 33, false, 11, null },
                    { 34, false, 12, null },
                    { 35, false, 12, null },
                    { 36, false, 12, null },
                    { 37, false, 13, null },
                    { 38, false, 13, null },
                    { 39, false, 13, null },
                    { 40, false, 14, null },
                    { 41, false, 14, null },
                    { 42, false, 14, null },
                    { 43, false, 15, null },
                    { 44, false, 15, null },
                    { 45, false, 15, null },
                    { 46, false, 16, null },
                    { 47, false, 16, null },
                    { 48, false, 16, null },
                    { 49, false, 17, null },
                    { 50, false, 17, null },
                    { 51, false, 17, null },
                    { 52, false, 18, null },
                    { 53, false, 18, null },
                    { 54, false, 18, null },
                    { 55, false, 19, null },
                    { 56, false, 19, null },
                    { 57, false, 19, null },
                    { 58, false, 20, null },
                    { 59, false, 20, null },
                    { 60, false, 20, null },
                    { 61, false, 21, null },
                    { 62, false, 21, null },
                    { 63, false, 21, null },
                    { 64, false, 22, null },
                    { 65, false, 22, null },
                    { 66, false, 22, null },
                    { 67, false, 23, null },
                    { 68, false, 23, null },
                    { 69, false, 23, null },
                    { 70, false, 24, null },
                    { 71, false, 24, null },
                    { 72, false, 24, null },
                    { 73, false, 25, null },
                    { 74, false, 25, null },
                    { 75, false, 25, null },
                    { 76, false, 26, null },
                    { 77, false, 26, null },
                    { 78, false, 26, null },
                    { 79, false, 27, null },
                    { 80, false, 27, null },
                    { 81, false, 27, null },
                    { 82, false, 28, null },
                    { 83, false, 28, null },
                    { 84, false, 28, null },
                    { 85, false, 29, null },
                    { 86, false, 29, null },
                    { 87, false, 29, null },
                    { 88, false, 30, null },
                    { 89, false, 30, null },
                    { 90, false, 30, null },
                    { 91, false, 31, null },
                    { 92, false, 31, null },
                    { 93, false, 31, null },
                    { 94, false, 32, null },
                    { 95, false, 32, null },
                    { 96, false, 32, null },
                    { 97, false, 33, null },
                    { 98, false, 33, null },
                    { 99, false, 33, null },
                    { 100, false, 34, null },
                    { 101, false, 34, null },
                    { 102, false, 34, null },
                    { 103, false, 35, null },
                    { 104, false, 35, null },
                    { 105, false, 35, null },
                    { 106, false, 36, null },
                    { 107, false, 36, null },
                    { 108, false, 36, null },
                    { 109, false, 37, null },
                    { 110, false, 37, null },
                    { 111, false, 37, null },
                    { 112, false, 38, null },
                    { 113, false, 38, null },
                    { 114, false, 38, null },
                    { 115, false, 39, null },
                    { 116, false, 39, null },
                    { 117, false, 39, null },
                    { 118, false, 40, null },
                    { 119, false, 40, null },
                    { 120, false, 40, null },
                    { 121, false, 41, null },
                    { 122, false, 41, null },
                    { 123, false, 41, null },
                    { 124, false, 42, null },
                    { 125, false, 42, null },
                    { 126, false, 42, null },
                    { 127, false, 43, null },
                    { 128, false, 43, null },
                    { 129, false, 43, null },
                    { 130, false, 44, null },
                    { 131, false, 44, null },
                    { 132, false, 44, null },
                    { 133, false, 45, null },
                    { 134, false, 45, null },
                    { 135, false, 45, null },
                    { 136, false, 46, null },
                    { 137, false, 46, null },
                    { 138, false, 46, null },
                    { 139, false, 47, null },
                    { 140, false, 47, null },
                    { 141, false, 47, null },
                    { 142, false, 48, null },
                    { 143, false, 48, null },
                    { 144, false, 48, null },
                    { 145, false, 49, null },
                    { 146, false, 49, null },
                    { 147, false, 49, null },
                    { 148, false, 50, null },
                    { 149, false, 50, null },
                    { 150, false, 50, null },
                    { 151, false, 51, null },
                    { 152, false, 51, null },
                    { 153, false, 51, null },
                    { 154, false, 52, null },
                    { 155, false, 52, null },
                    { 156, false, 52, null },
                    { 157, false, 53, null },
                    { 158, false, 53, null },
                    { 159, false, 53, null },
                    { 160, false, 54, null },
                    { 161, false, 54, null },
                    { 162, false, 54, null },
                    { 163, false, 55, null },
                    { 164, false, 55, null },
                    { 165, false, 55, null },
                    { 166, false, 56, null },
                    { 167, false, 56, null },
                    { 168, false, 56, null },
                    { 169, false, 57, null },
                    { 170, false, 57, null },
                    { 171, false, 57, null },
                    { 172, false, 58, null },
                    { 173, false, 58, null },
                    { 174, false, 58, null },
                    { 175, false, 59, null },
                    { 176, false, 59, null },
                    { 177, false, 59, null },
                    { 178, false, 60, null },
                    { 179, false, 60, null },
                    { 180, false, 60, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Mines_ResourceId",
                table: "Mines",
                column: "ResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Planets_SolarSystemId",
                table: "Planets",
                column: "SolarSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_Regions_PlanetId",
                table: "Regions",
                column: "PlanetId");

            migrationBuilder.CreateIndex(
                name: "IX_Regions_UserId",
                table: "Regions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RegionStructures_RegionId",
                table: "RegionStructures",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Structures_MineId",
                table: "Structures",
                column: "MineId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "RegionStructures");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "Structures");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Planets");

            migrationBuilder.DropTable(
                name: "Mines");

            migrationBuilder.DropTable(
                name: "SolarSystems");

            migrationBuilder.DropTable(
                name: "Resources");
        }
    }
}
