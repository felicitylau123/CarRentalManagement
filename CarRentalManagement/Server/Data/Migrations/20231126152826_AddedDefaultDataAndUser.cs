using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "b399a870-46a4-4d6b-bb25-67f13ff500ea", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEMlEkymyofKlm1BZ0CPQiD+K8ykn5/mEfaGmFG86ZuOi1q5pvaTNfH4iOF1lpyW/5g==", null, false, "f88801b0-4b7a-4838-af30-d12587ebbb4a", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 26, 23, 28, 25, 861, DateTimeKind.Local).AddTicks(5701), new DateTime(2023, 11, 26, 23, 28, 25, 861, DateTimeKind.Local).AddTicks(5714), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 26, 23, 28, 25, 861, DateTimeKind.Local).AddTicks(5717), new DateTime(2023, 11, 26, 23, 28, 25, 861, DateTimeKind.Local).AddTicks(5718), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 26, 23, 28, 25, 861, DateTimeKind.Local).AddTicks(6044), new DateTime(2023, 11, 26, 23, 28, 25, 861, DateTimeKind.Local).AddTicks(6045), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 26, 23, 28, 25, 861, DateTimeKind.Local).AddTicks(6046), new DateTime(2023, 11, 26, 23, 28, 25, 861, DateTimeKind.Local).AddTicks(6047), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 26, 23, 28, 25, 861, DateTimeKind.Local).AddTicks(6239), new DateTime(2023, 11, 26, 23, 28, 25, 861, DateTimeKind.Local).AddTicks(6240), "3 series", "System" },
                    { 2, "System", new DateTime(2023, 11, 26, 23, 28, 25, 861, DateTimeKind.Local).AddTicks(6242), new DateTime(2023, 11, 26, 23, 28, 25, 861, DateTimeKind.Local).AddTicks(6243), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 26, 23, 28, 25, 861, DateTimeKind.Local).AddTicks(6244), new DateTime(2023, 11, 26, 23, 28, 25, 861, DateTimeKind.Local).AddTicks(6244), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 26, 23, 28, 25, 861, DateTimeKind.Local).AddTicks(6245), new DateTime(2023, 11, 26, 23, 28, 25, 861, DateTimeKind.Local).AddTicks(6246), "RAV4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
