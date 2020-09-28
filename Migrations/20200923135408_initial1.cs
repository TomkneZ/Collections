using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Collections.Migrations
{
    public partial class initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Collections",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    shortDescription = table.Column<string>(nullable: true),
                    Theme = table.Column<int>(nullable: false),
                    TitleImagePath = table.Column<string>(nullable: true),
                    itemFields = table.Column<int>(nullable: false),
                    Num1Name = table.Column<string>(nullable: true),
                    Num2Name = table.Column<string>(nullable: true),
                    Num3Name = table.Column<string>(nullable: true),
                    Input1Name = table.Column<string>(nullable: true),
                    Input2Name = table.Column<string>(nullable: true),
                    Input3Name = table.Column<string>(nullable: true),
                    Textarea1Name = table.Column<string>(nullable: true),
                    Textarea2Name = table.Column<string>(nullable: true),
                    Textarea3Name = table.Column<string>(nullable: true),
                    Date1Name = table.Column<string>(nullable: true),
                    Date2Name = table.Column<string>(nullable: true),
                    Date3Name = table.Column<string>(nullable: true),
                    Checkbox1Name = table.Column<string>(nullable: true),
                    Checkbox2Name = table.Column<string>(nullable: true),
                    Checkbox3Name = table.Column<string>(nullable: true),
                    ownerId = table.Column<string>(nullable: true),
                    numberOfItems = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CollectionId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Tag = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    Num1Value = table.Column<int>(nullable: false),
                    Num2Value = table.Column<int>(nullable: false),
                    Num3Value = table.Column<int>(nullable: false),
                    Input1Value = table.Column<string>(nullable: true),
                    Input2Value = table.Column<string>(nullable: true),
                    Input3Value = table.Column<string>(nullable: true),
                    Textarea1Value = table.Column<string>(nullable: true),
                    Textarea2Value = table.Column<string>(nullable: true),
                    Textarea3Value = table.Column<string>(nullable: true),
                    Date1Value = table.Column<string>(nullable: true),
                    Date2Value = table.Column<string>(nullable: true),
                    Date3Value = table.Column<string>(nullable: true),
                    Checkbox1Value = table.Column<bool>(nullable: false),
                    Checkbox2Value = table.Column<bool>(nullable: false),
                    Checkbox3Value = table.Column<bool>(nullable: false),
                    itemFields = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    shortDescription = table.Column<string>(nullable: true),
                    Theme = table.Column<int>(nullable: false),
                    TitleImagePath = table.Column<string>(nullable: true),
                    itemFields = table.Column<int>(nullable: false),
                    ownerId = table.Column<string>(nullable: true),
                    numberOfItems = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TextFields",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    CodeWord = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextFields", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "44546e06-8719-4ad8-b88a-f271ae9d6eab", "a9c8194f-7b49-4cbc-97ef-6f17ac3fe462", "admin", "ADMIN" },
                    { "33425d95-7608-3zc7-a77z-e160zd8c5dza", "5478a606-554f-42a3-9809-466b167de43b", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3b62472e-4f66-49fa-a20f-e7685b9565d8", 0, "e6b5cea8-69ce-4c75-8227-2ae3a7f67aa4", "my@email.com", true, false, null, "MY@EMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEDtj4disKC5tvLF4f6AMVCCK7MBY6mO/9GTVNywbatAFy6lUGKj14t906IqIibiz+w==", null, false, "", false, "admin" },
                    { "2a52361d-3e55-38ez-z19e-d6574a8454c7", 0, "5b75e49a-344e-4bb1-b6f5-0b5eb97d3b64", "ksusha@email.com", true, false, null, "KSUSHA@EMAIL.COM", "KSU2001", "AQAAAAEAACcQAAAAENuMmwsQYwFYVgCg7SsHUvOqbTpcoVg8V6LD7+jPa9/YNQUx3tWv+IRwnGp14tDbjg==", null, false, "", false, "Ksu2001" },
                    { "2a99991d-3e99-99ez-z19e-d6574a8454c7", 0, "b40cf33a-6540-4aa8-92a9-9ebb4a3845ee", "zabenkotoi@gmail.com", true, false, null, "ZABENKOTOI@GMAIL.COM", "TOKNEZ", "AQAAAAEAACcQAAAAEBme734hdSDLBi9uyKBoQ8tpmSVsdr8OCFH+01hcXORHSUzhD8njpY0Ex5TYaLlOuA==", null, false, "", false, "Toknez" },
                    { "2a00001d-3e00-99ez-z00e-d6574a8454c7", 0, "92f9368c-b7dc-4149-9157-436e49201517", "zabenkoea@yandex.ru", true, false, null, "ZABENKOEA@YANDEX.RU", "HANNARENETS", "AQAAAAEAACcQAAAAEOt0RPA7rnMfweNWDzZVHSwQOQlDX+vQ8NCsFH5DJhAqGsjHmHHkJVUGllkfu6gyWQ==", null, false, "", false, "hannarenets" }
                });

            migrationBuilder.InsertData(
                table: "TextFields",
                columns: new[] { "Id", "CodeWord", "Title", "Type", "Value" },
                values: new object[,]
                {
                    { new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"), "PageIndex", "Main", null, null },
                    { new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"), "PageServices", "Our services", null, null },
                    { new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"), "PageContacts", "Contact us", null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "3b62472e-4f66-49fa-a20f-e7685b9565d8", "44546e06-8719-4ad8-b88a-f271ae9d6eab" },
                    { "2a52361d-3e55-38ez-z19e-d6574a8454c7", "33425d95-7608-3zc7-a77z-e160zd8c5dza" },
                    { "2a99991d-3e99-99ez-z19e-d6574a8454c7", "33425d95-7608-3zc7-a77z-e160zd8c5dza" },
                    { "2a00001d-3e00-99ez-z00e-d6574a8454c7", "33425d95-7608-3zc7-a77z-e160zd8c5dza" }
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
        }

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
                name: "Collections");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "ServiceItems");

            migrationBuilder.DropTable(
                name: "TextFields");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
