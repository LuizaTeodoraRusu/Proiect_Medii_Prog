using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RESTAURANT.Migrations
{
    public partial class AdaugareProprietatiNavigare : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LocationMenu",
                columns: table => new
                {
                    LocationsLocationId = table.Column<int>(type: "int", nullable: false),
                    MenusMenuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationMenu", x => new { x.LocationsLocationId, x.MenusMenuId });
                    table.ForeignKey(
                        name: "FK_LocationMenu_Location_LocationsLocationId",
                        column: x => x.LocationsLocationId,
                        principalTable: "Location",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocationMenu_Menu_MenusMenuId",
                        column: x => x.MenusMenuId,
                        principalTable: "Menu",
                        principalColumn: "MenuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LocationMenu_MenusMenuId",
                table: "LocationMenu",
                column: "MenusMenuId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocationMenu");
        }
    }
}
