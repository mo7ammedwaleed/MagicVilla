using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedSomeDataToVillaNumberTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "VillaNumbers",
                columns: new[] { "VillaNo", "CreatedDate", "SpecialDetails", "UpdatedDate", "VillaID" },
                values: new object[,]
                {
                    { 101, new DateTime(2025, 4, 20, 18, 50, 36, 253, DateTimeKind.Local).AddTicks(1799), "Special Details", new DateTime(2025, 4, 20, 18, 50, 36, 253, DateTimeKind.Local).AddTicks(1800), 1 },
                    { 102, new DateTime(2025, 4, 20, 18, 50, 36, 253, DateTimeKind.Local).AddTicks(1802), "Special Details", new DateTime(2025, 4, 20, 18, 50, 36, 253, DateTimeKind.Local).AddTicks(1804), 1 },
                    { 103, new DateTime(2025, 4, 20, 18, 50, 36, 253, DateTimeKind.Local).AddTicks(1805), "Special Details", new DateTime(2025, 4, 20, 18, 50, 36, 253, DateTimeKind.Local).AddTicks(1807), 2 },
                    { 104, new DateTime(2025, 4, 20, 18, 50, 36, 253, DateTimeKind.Local).AddTicks(1808), "Special Details", new DateTime(2025, 4, 20, 18, 50, 36, 253, DateTimeKind.Local).AddTicks(1809), 2 }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 104);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 19, 17, 37, 10, 62, DateTimeKind.Local).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 19, 17, 37, 10, 62, DateTimeKind.Local).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 19, 17, 37, 10, 62, DateTimeKind.Local).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 19, 17, 37, 10, 62, DateTimeKind.Local).AddTicks(3876));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 19, 17, 37, 10, 62, DateTimeKind.Local).AddTicks(3879));
        }
    }
}
