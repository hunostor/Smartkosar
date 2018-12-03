using Microsoft.EntityFrameworkCore.Migrations;

namespace Probafeladat.Data.Migrations
{
    public partial class ShippingStateAddSequence : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Sequence",
                table: "ShippingStates",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sequence",
                table: "ShippingStates");
        }
    }
}
