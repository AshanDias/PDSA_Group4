using Microsoft.EntityFrameworkCore.Migrations;

namespace Nibm.Pdsa.Group4.Migrations
{
    public partial class addDistance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Distance",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    fromStationId = table.Column<int>(nullable: false),
                    toStationId = table.Column<int>(nullable: false),
                    DistanceKm = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Distance_Station_fromStationId",
                        column: x => x.fromStationId,
                        principalTable: "Station",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Distance_Station_toStationId",
                        column: x => x.toStationId,
                        principalTable: "Station",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Distance_fromStationId",
                table: "Distance",
                column: "fromStationId");

            migrationBuilder.CreateIndex(
                name: "IX_Distance_toStationId",
                table: "Distance",
                column: "toStationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Distance");
        }
    }
}
