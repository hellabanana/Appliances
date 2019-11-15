﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Appliances.Migrations
{
    public partial class ProductAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

        //    migrationBuilder.CreateTable(
        //        name: "Roles",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            Name = table.Column<string>(nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Roles", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Users",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            Email = table.Column<string>(nullable: true),
        //            Password = table.Column<string>(nullable: true),
        //            RoleId = table.Column<int>(nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Users", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_Users_Roles_RoleId",
        //                column: x => x.RoleId,
        //                principalTable: "Roles",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.InsertData(
        //        table: "Products",
        //        columns: new[] { "Id", "Description", "Image", "Name", "Price" },
        //        values: new object[] { 6, "Lorem Ipsum", "https://tehnoplus.by/image/cache/data/prd/1353114/0-960x720.jpg", "Холодильник 6", "315" });

        //    migrationBuilder.InsertData(
        //        table: "Roles",
        //        columns: new[] { "Id", "Name" },
        //        values: new object[] { 1, "admin" });

        //    migrationBuilder.InsertData(
        //        table: "Roles",
        //        columns: new[] { "Id", "Name" },
        //        values: new object[] { 2, "user" });

        //    migrationBuilder.InsertData(
        //        table: "Users",
        //        columns: new[] { "Id", "Email", "Password", "RoleId" },
        //        values: new object[] { 1, "admin@mail.ru", "123456", 1 });

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Users_RoleId",
        //        table: "Users",
        //        column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
