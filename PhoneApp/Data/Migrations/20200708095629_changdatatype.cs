using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhoneApp.Data.Migrations
{
    public partial class changdatatype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhoneContacts_Contacts_ContactId",
                table: "PhoneContacts");

            migrationBuilder.DropIndex(
                name: "IX_PhoneContacts_ContactId",
                table: "PhoneContacts");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "PhoneContacts",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "PhoneContactId",
                table: "PhoneContacts",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<Guid>(
                name: "ContactId1",
                table: "PhoneContacts",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NationalCode",
                table: "Contacts",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Contacts",
                maxLength: 35,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Firstname",
                table: "Contacts",
                maxLength: 35,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ContactId",
                table: "Contacts",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneContacts_ContactId1",
                table: "PhoneContacts",
                column: "ContactId1");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneContacts_Contacts_ContactId1",
                table: "PhoneContacts",
                column: "ContactId1",
                principalTable: "Contacts",
                principalColumn: "ContactId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhoneContacts_Contacts_ContactId1",
                table: "PhoneContacts");

            migrationBuilder.DropIndex(
                name: "IX_PhoneContacts_ContactId1",
                table: "PhoneContacts");

            migrationBuilder.DropColumn(
                name: "ContactId1",
                table: "PhoneContacts");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "PhoneContacts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<int>(
                name: "PhoneContactId",
                table: "PhoneContacts",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid))
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "NationalCode",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 35);

            migrationBuilder.AlterColumn<string>(
                name: "Firstname",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 35);

            migrationBuilder.AlterColumn<int>(
                name: "ContactId",
                table: "Contacts",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid))
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneContacts_ContactId",
                table: "PhoneContacts",
                column: "ContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneContacts_Contacts_ContactId",
                table: "PhoneContacts",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "ContactId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
