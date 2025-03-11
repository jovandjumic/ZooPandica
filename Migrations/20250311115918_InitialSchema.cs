using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooPandica.Migrations
{
    /// <inheritdoc />
    public partial class InitialSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BrojLajkova",
                table: "Events");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "Tip",
                table: "Tickets",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "PosetilacID",
                table: "Tickets",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "Cena",
                table: "Tickets",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "Poruka",
                table: "Notifications",
                newName: "Message");

            migrationBuilder.RenameColumn(
                name: "Slika",
                table: "Events",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Opis",
                table: "Events",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "Naziv",
                table: "Events",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Slika",
                table: "Animals",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Opis",
                table: "Animals",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "Ime",
                table: "Animals",
                newName: "Description");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PromoCode",
                table: "Tickets",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Events",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PromoCode",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Events");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Tickets",
                newName: "PosetilacID");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Tickets",
                newName: "Tip");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Tickets",
                newName: "Cena");

            migrationBuilder.RenameColumn(
                name: "Message",
                table: "Notifications",
                newName: "Poruka");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Events",
                newName: "Slika");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Events",
                newName: "Opis");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Events",
                newName: "Naziv");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Animals",
                newName: "Slika");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Animals",
                newName: "Opis");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Animals",
                newName: "Ime");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "BrojLajkova",
                table: "Events",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
