﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace kingsmen.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PageId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    UrlSlug = table.Column<string>(nullable: true),
                    SecretIdentity = table.Column<string>(nullable: true),
                    Align = table.Column<string>(nullable: true),
                    Eye = table.Column<string>(nullable: true),
                    Hair = table.Column<string>(nullable: true),
                    Sex = table.Column<string>(nullable: true),
                    GSM = table.Column<string>(nullable: true),
                    Alive = table.Column<string>(nullable: true),
                    Appearances = table.Column<string>(nullable: true),
                    FirstAppearanceDate = table.Column<string>(nullable: true),
                    FirstAppearanceYear = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");
        }
    }
}
