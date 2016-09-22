using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace hwnn.Migrations
{
    public partial class SeccondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerContactId",
                table: "Customers",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                table: "Customers",
                maxLength: 50,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CustomerContactId",
                table: "Customers",
                column: "CustomerContactId");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Contacts",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Contacts",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Contacts_CustomerContactId",
                table: "Customers",
                column: "CustomerContactId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Contacts_CustomerContactId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_CustomerContactId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CustomerContactId",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                table: "Customers",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Contacts",
                nullable: true);
        }
    }
}
