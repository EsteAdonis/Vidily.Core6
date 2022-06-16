using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Core6.Data.Migrations
{
    public partial class AddingMembershipTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.Sql("Insert MembershipTypes(Id, SignUpFee, DurationInMonths, DiscountRate) Values(1, 0, 0, 0)");
      migrationBuilder.Sql("Insert MembershipTypes(Id, SignUpFee, DurationInMonths, DiscountRate) Values(2, 30, 1, 10)");
      migrationBuilder.Sql("Insert MembershipTypes(Id, SignUpFee, DurationInMonths, DiscountRate) Values(3, 90, 3, 50)");
      migrationBuilder.Sql("Insert MembershipTypes(Id, SignUpFee, DurationInMonths, DiscountRate) Values(4, 300, 12, 20)");                  
    }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
