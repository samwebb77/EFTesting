using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFTesting.Migrations
{
    /// <inheritdoc />
    public partial class DateTimeMigrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(name: "DateTemp",
                table: "Dates",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()");

            migrationBuilder.Sql(@"
                UPDATE Dates
                SET DateTemp = CONVERT(DATETIME, Date, 102)
                ");

            migrationBuilder.DropColumn("Date", "Dates");
            migrationBuilder.RenameColumn("DateTemp", "Dates", "Date");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "Dates",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
