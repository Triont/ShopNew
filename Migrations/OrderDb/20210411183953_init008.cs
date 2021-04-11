using Microsoft.EntityFrameworkCore.Migrations;

namespace NewShopApp.Migrations.OrderDb
{
    public partial class init008 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Orders",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Orders",
                newName: "id");
        }
    }
}
