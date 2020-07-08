using Microsoft.EntityFrameworkCore.Migrations;

namespace PhoneApp.Data.Migrations
{
    public partial class changRe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_PhoneContacts_PhoneContactId",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_PhoneContactId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "PhoneContactId",
                table: "Contacts");

            migrationBuilder.AddColumn<int>(
                name: "ContactId",
                table: "PhoneContacts",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhoneContacts_Contacts_ContactId",
                table: "PhoneContacts");

            migrationBuilder.DropIndex(
                name: "IX_PhoneContacts_ContactId",
                table: "PhoneContacts");

            migrationBuilder.DropColumn(
                name: "ContactId",
                table: "PhoneContacts");

            migrationBuilder.AddColumn<int>(
                name: "PhoneContactId",
                table: "Contacts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_PhoneContactId",
                table: "Contacts",
                column: "PhoneContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_PhoneContacts_PhoneContactId",
                table: "Contacts",
                column: "PhoneContactId",
                principalTable: "PhoneContacts",
                principalColumn: "PhoneContactId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
