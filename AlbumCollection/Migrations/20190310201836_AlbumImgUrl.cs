using Microsoft.EntityFrameworkCore.Migrations;

namespace AlbumCollection.Migrations
{
    public partial class AlbumImgUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Albums",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 1,
                column: "ImageUrl",
                value: "/Images/nostalgia.jpg");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 2,
                column: "ImageUrl",
                value: "/Images/orange.jpg");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 3,
                column: "ImageUrl",
                value: "/Images/blonde.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Albums");
        }
    }
}
