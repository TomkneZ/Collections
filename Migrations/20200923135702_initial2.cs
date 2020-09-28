using Microsoft.EntityFrameworkCore.Migrations;

namespace Collections.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33425d95-7608-3zc7-a77z-e160zd8c5dza",
                column: "ConcurrencyStamp",
                value: "12720d3a-5280-4efd-9ad4-8537096a5b1a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "3148fbf4-53b2-4478-a51d-6697fff047f9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a00001d-3e00-99ez-z00e-d6574a8454c7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5811c38d-a075-4444-aa6f-ea364aff9e8f", "AQAAAAEAACcQAAAAEPLc0PaRc/xNOeQWWE0pSAohhURW11sYeqty6VY6HYQ3rGsJga/E1O51UljqZkK30A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a52361d-3e55-38ez-z19e-d6574a8454c7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "68c39fe0-d323-4d74-a70f-e576da896c55", "AQAAAAEAACcQAAAAELA+hVNAGTG6rRSN1T+Lrha0OMWojRAqaxB7myuic1qbclXHra6sPoAE6L4/c5Zgmg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a99991d-3e99-99ez-z19e-d6574a8454c7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "877aa505-be61-4a13-937f-e0223f15f1f9", "AQAAAAEAACcQAAAAEK4pf+aEfYfuP4wKn9JMygb2YmKVEej3mkB3nv6ZE/++lFBQmR0fNbI/aPcO/IGQpw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d54b9d60-88a1-4832-91d0-ec3d2219d33f", "AQAAAAEAACcQAAAAEK7gMMH73JNkS6Uwmbj57Bn0n0hs/qLe8BOAdgbVCUvcfDF/0h6pRSmUKw084uYptw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33425d95-7608-3zc7-a77z-e160zd8c5dza",
                column: "ConcurrencyStamp",
                value: "5478a606-554f-42a3-9809-466b167de43b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "a9c8194f-7b49-4cbc-97ef-6f17ac3fe462");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a00001d-3e00-99ez-z00e-d6574a8454c7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "92f9368c-b7dc-4149-9157-436e49201517", "AQAAAAEAACcQAAAAEOt0RPA7rnMfweNWDzZVHSwQOQlDX+vQ8NCsFH5DJhAqGsjHmHHkJVUGllkfu6gyWQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a52361d-3e55-38ez-z19e-d6574a8454c7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5b75e49a-344e-4bb1-b6f5-0b5eb97d3b64", "AQAAAAEAACcQAAAAENuMmwsQYwFYVgCg7SsHUvOqbTpcoVg8V6LD7+jPa9/YNQUx3tWv+IRwnGp14tDbjg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a99991d-3e99-99ez-z19e-d6574a8454c7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b40cf33a-6540-4aa8-92a9-9ebb4a3845ee", "AQAAAAEAACcQAAAAEBme734hdSDLBi9uyKBoQ8tpmSVsdr8OCFH+01hcXORHSUzhD8njpY0Ex5TYaLlOuA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e6b5cea8-69ce-4c75-8227-2ae3a7f67aa4", "AQAAAAEAACcQAAAAEDtj4disKC5tvLF4f6AMVCCK7MBY6mO/9GTVNywbatAFy6lUGKj14t906IqIibiz+w==" });
        }
    }
}
