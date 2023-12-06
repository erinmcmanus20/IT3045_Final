using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IT3045Final.Migrations
{
    /// <inheritdoc />
    public partial class InitialSports : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SportsTeamMember",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamMemberName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SportsName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birthdate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoOfMatchesPlayed = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SportsTeamMember", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "SportsTeamMember",
                columns: new[] { "Id", "Birthdate", "NoOfMatchesPlayed", "SportsName", "TeamMemberName" },
                values: new object[,]
                {
                    { 1, "12/1/2004", "12", "Cricket", "James Smith" },
                    { 2, "2/10/2007", "12", "Soccer", "Robert Johnson" },
                    { 3, "9/4/2008", "12", "BasketBall", "Maria Garcia" },
                    { 4, "11/9/2005", "12", "Hockey", "Taylor Miller" },
                    { 5, "6/12/2008", "12", "Soccer", "Davis Jones" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SportsTeamMember");
        }
    }
}
