using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Outlet.Demo.DataServices.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admins",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_name = table.Column<string>(type: "text", nullable: true),
                    pass_word = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_admins", x => x.user_id);
                });

            migrationBuilder.CreateTable(
                name: "outlets",
                columns: table => new
                {
                    outlet_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    outlet_name = table.Column<string>(type: "text", nullable: true),
                    street_name = table.Column<string>(type: "text", nullable: true),
                    landmark = table.Column<string>(type: "text", nullable: true),
                    no_of_packets = table.Column<int>(type: "integer", nullable: false),
                    no_of_volunteers = table.Column<int>(type: "integer", nullable: false),
                    food_type = table.Column<string>(type: "text", nullable: true),
                    date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_outlets", x => x.outlet_id);
                });

            migrationBuilder.CreateTable(
                name: "volunteers",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    volunteer_name = table.Column<string>(type: "text", nullable: true),
                    location = table.Column<string>(type: "text", nullable: true),
                    volunteer_outlet_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_volunteers", x => x.id);
                    table.ForeignKey(
                        name: "fk_volunteers_outlets_volunteer_outlet_id",
                        column: x => x.volunteer_outlet_id,
                        principalTable: "outlets",
                        principalColumn: "outlet_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "admins",
                columns: new[] { "user_id", "pass_word", "user_name" },
                values: new object[] { 1, "san", "Nimisha" });

            migrationBuilder.CreateIndex(
                name: "ix_volunteers_volunteer_outlet_id",
                table: "volunteers",
                column: "volunteer_outlet_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admins");

            migrationBuilder.DropTable(
                name: "volunteers");

            migrationBuilder.DropTable(
                name: "outlets");
        }
    }
}
