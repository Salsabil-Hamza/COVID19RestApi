using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace COVID19API.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "COVID19",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastReleaseDate = table.Column<DateTime>(nullable: false),
                    MortalityRate = table.Column<double>(nullable: false),
                    Population = table.Column<double>(nullable: false),
                    Strategy = table.Column<string>(nullable: true),
                    CityName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COVID19", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "COVID19");
        }
    }
}
