using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddLocalUsersToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LocalUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalUsers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 101,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 18, 1, 28, 387, DateTimeKind.Local).AddTicks(2418), new DateTime(2025, 5, 4, 18, 1, 28, 387, DateTimeKind.Local).AddTicks(2421) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 102,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 18, 1, 28, 387, DateTimeKind.Local).AddTicks(2423), new DateTime(2025, 5, 4, 18, 1, 28, 387, DateTimeKind.Local).AddTicks(2424) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 103,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 18, 1, 28, 387, DateTimeKind.Local).AddTicks(2426), new DateTime(2025, 5, 4, 18, 1, 28, 387, DateTimeKind.Local).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 104,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 4, 18, 1, 28, 387, DateTimeKind.Local).AddTicks(2430), new DateTime(2025, 5, 4, 18, 1, 28, 387, DateTimeKind.Local).AddTicks(2431) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 4, 18, 1, 28, 387, DateTimeKind.Local).AddTicks(2269));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 4, 18, 1, 28, 387, DateTimeKind.Local).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 4, 18, 1, 28, 387, DateTimeKind.Local).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 4, 18, 1, 28, 387, DateTimeKind.Local).AddTicks(2324));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 4, 18, 1, 28, 387, DateTimeKind.Local).AddTicks(2326));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocalUsers");

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 101,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 20, 18, 50, 36, 253, DateTimeKind.Local).AddTicks(1799), new DateTime(2025, 4, 20, 18, 50, 36, 253, DateTimeKind.Local).AddTicks(1800) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 102,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 20, 18, 50, 36, 253, DateTimeKind.Local).AddTicks(1802), new DateTime(2025, 4, 20, 18, 50, 36, 253, DateTimeKind.Local).AddTicks(1804) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 103,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 20, 18, 50, 36, 253, DateTimeKind.Local).AddTicks(1805), new DateTime(2025, 4, 20, 18, 50, 36, 253, DateTimeKind.Local).AddTicks(1807) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 104,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 20, 18, 50, 36, 253, DateTimeKind.Local).AddTicks(1808), new DateTime(2025, 4, 20, 18, 50, 36, 253, DateTimeKind.Local).AddTicks(1809) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 20, 18, 50, 36, 253, DateTimeKind.Local).AddTicks(1645));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 20, 18, 50, 36, 253, DateTimeKind.Local).AddTicks(1694));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 20, 18, 50, 36, 253, DateTimeKind.Local).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 20, 18, 50, 36, 253, DateTimeKind.Local).AddTicks(1699));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 20, 18, 50, 36, 253, DateTimeKind.Local).AddTicks(1701));
        }
    }
}
