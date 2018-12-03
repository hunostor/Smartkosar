using Microsoft.EntityFrameworkCore.Migrations;

namespace Probafeladat.Data.Migrations
{
    public partial class ShippingStateAddDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "ShippingStates",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 120);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ShippingStates",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Short",
                table: "ShippingStates",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "ShippingStates",
                columns: new[] { "ID", "Description", "Sequence", "Short", "State" },
                values: new object[,]
                {
                    { 1, "Csomag a feladónál. Futárra vár.", 1, "WfpU", "Waiting for Pick Up" },
                    { 2, "Csomag a futárnál. Depóba tart.", 2, "PU", "Picked Up" },
                    { 3, "Depóban van. Kiszállításra vár", 3, "ID", "In Depot" },
                    { 5, "Kiszállítás alatt áll. Célba tart.", 4, "OD", "On Delivery" },
                    { 6, "Kiszállítva", 5, "DD", "Delivered" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ShippingStates",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ShippingStates",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ShippingStates",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ShippingStates",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ShippingStates",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ShippingStates");

            migrationBuilder.DropColumn(
                name: "Short",
                table: "ShippingStates");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "ShippingStates",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 150);
        }
    }
}
