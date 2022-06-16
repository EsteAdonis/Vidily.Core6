using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Core6.Data.Migrations
{
    public partial class AddNameColumnToMembershipType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "MembershipTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "MembershipTypes");
        }
    }
}
