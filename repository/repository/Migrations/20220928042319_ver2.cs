using Microsoft.EntityFrameworkCore.Migrations;

namespace repository.Migrations
{
    public partial class ver2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "rrrrrrr",
                table: "minh",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "qqqqq",
                table: "minh",
                newName: "MSSV");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "minh",
                newName: "rrrrrrr");

            migrationBuilder.RenameColumn(
                name: "MSSV",
                table: "minh",
                newName: "qqqqq");
        }
    }
}
