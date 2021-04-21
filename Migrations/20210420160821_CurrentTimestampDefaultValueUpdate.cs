using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogApi.Migrations
{
    public partial class CurrentTimestampDefaultValueUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedTimestamp",
                table: "Posts",
                type: "TEXT",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTimestamp",
                table: "Blogs",
                type: "TEXT",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "JoinTimestamp",
                table: "Authors",
                type: "TEXT",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValueSql: "getdate()");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedTimestamp",
                table: "Posts",
                type: "TEXT",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTimestamp",
                table: "Blogs",
                type: "TEXT",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<DateTime>(
                name: "JoinTimestamp",
                table: "Authors",
                type: "TEXT",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");
        }
    }
}
