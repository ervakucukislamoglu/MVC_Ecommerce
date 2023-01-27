using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Ecommerce.Migrations
{
    public partial class userorderrelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AppUserID",
                table: "Orders",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AppUserID",
                table: "Orders",
                column: "AppUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_AppUserID",
                table: "Orders",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_AppUserID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_AppUserID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "Orders");
        }
    }
}
