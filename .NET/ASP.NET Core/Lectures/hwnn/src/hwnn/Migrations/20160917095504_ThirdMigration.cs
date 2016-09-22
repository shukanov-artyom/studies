using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace hwnn.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerContactId",
                table: "Customers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CustomerContactId",
                table: "Customers",
                column: "CustomerContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Contacts_CustomerContactId",
                table: "Customers",
                column: "CustomerContactId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
