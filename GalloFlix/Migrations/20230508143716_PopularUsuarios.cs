using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalloFlix.Migrations
{
    public partial class PopularUsuarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "12d3acfe-134d-48fd-881a-9f3b8258aa43", "fca97e88-9cd1-4dc1-bb36-6757f51a38c2", "Usuário", "USUÁRIO" },
                    { "4be503fe-ad31-4d53-9f1e-64f686993f16", "e2309929-2a67-4298-a737-180072926c9b", "Administrador", "ADMINISTRADOR" },
                    { "5307ad1d-851d-4156-8d0b-eee4dfb07439", "508a8d2a-3f95-45c6-a280-78502495fa12", "Moderador", "MODERADOR" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c60f46c0-695a-4a11-805f-c94ba8ae1430", 0, "d9019684-c99a-4bfc-bf56-a02e23d0342d", new DateTime(1981, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "AppUser", "gallojunior@gmail.com", true, false, null, "José Antonio Gallo Junior", "GALLOJUNIOR@GMAIL.COM", "GALLOJUNIOR", "AQAAAAEAACcQAAAAEFyNPfLX8ILh9trgfwG3qJba/6RRLEUxrKDLlGKATvjweNphFTfOetQbTteZ3CPqtg==", "14981544857", true, "/img/users/avatar.png", "bf4bf2b0-dfb9-4d02-be2c-1f3b18bc49a3", false, "GalloJunior" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4be503fe-ad31-4d53-9f1e-64f686993f16", "c60f46c0-695a-4a11-805f-c94ba8ae1430" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "12d3acfe-134d-48fd-881a-9f3b8258aa43");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "5307ad1d-851d-4156-8d0b-eee4dfb07439");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4be503fe-ad31-4d53-9f1e-64f686993f16", "c60f46c0-695a-4a11-805f-c94ba8ae1430" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "4be503fe-ad31-4d53-9f1e-64f686993f16");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c60f46c0-695a-4a11-805f-c94ba8ae1430");
        }
    }
}
