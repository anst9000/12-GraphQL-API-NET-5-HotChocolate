using Microsoft.EntityFrameworkCore.Migrations;

namespace CommanderGQL.Migrations
{
    public partial class AddUpdatedPlatformToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "License",
                table: "Platforms",
                newName: "LicenseKey");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LicenseKey",
                table: "Platforms",
                newName: "License");
        }
    }
}
