using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleSocialNetwork.Migrations
{
    public partial class added_post_datetime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "PublishDateTime",
                table: "Posts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublishDateTime",
                table: "Posts");
        }
    }
}
