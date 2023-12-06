using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IT3045Final.Migrations
{
    /// <inheritdoc />
    public partial class InitialBaseball : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaseballTeams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Founded = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorldSeriesChampionships = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseballTeams", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BaseballTeams",
                columns: new[] { "Id", "City", "Founded", "State", "TeamName", "WorldSeriesChampionships" },
                values: new object[,]
                {
                    { 1, "Phoenix", "1998", "Arizona", "Diamondbacks", "1" },
                    { 2, "Atlanta", "1871", "Georgia", "Braves", "4" },
                    { 3, "Baltimore", "1894", "Maryland", "Orioles", "3" },
                    { 4, "Boston", "1901", "Massachusetts", "Red Sox", "9" },
                    { 5, "Chicago", "1876", "Illinois", "Cubs", "3" },
                    { 6, "Chicago", "1901", "Illinois", "White Sox", "3" },
                    { 7, "Cincinnati", "1881", "Ohio", "Reds", "5" },
                    { 8, "Cleveland", "1894", "Ohio", "Guardians", "2" },
                    { 9, "Denver", "1991", "Colorado", "Rockies", "0" },
                    { 10, "Detroit", "1894", "Michigan", "Tigers", "4" },
                    { 11, "Houston", "1962", "Texas", "Astros", "2" },
                    { 12, "Kansas City", "1969", "Missouri", "Royals", "2" },
                    { 13, "Anaheim", "1961", "California", "Angels", "1" },
                    { 14, "Los Angeles", "1883", "California", "Dodgers", "7" },
                    { 15, "Miami", "1991", "Florida", "Marlins", "2" },
                    { 16, "Milwaukee", "1969", "Wisconsin", "Brewers", "0" },
                    { 17, "Minneapolis", "1901", "Minnesota", "Twins", "3" },
                    { 18, "Flushing", "1962", "New York", "Mets", "2" },
                    { 19, "Bronx", "1903", "New York", "Yankees", "27" },
                    { 20, "Oakland", "1901", "California", "Athletics", "9" },
                    { 21, "Philadelphia", "1883", "Pennsylvania", "Phillies", "2" },
                    { 22, "Pittsburgh", "1882", "Pennsylvania", "Pirates", "5" },
                    { 23, "San Diego", "1969", "California", "Padres", "0" },
                    { 24, "San Francisco", "1883", "California", "Giants", "8" },
                    { 25, "Seattle", "1977", "Washington", "Mariners", "0" },
                    { 26, "St. Louis", "1882", "Missouri", "Cardinals", "11" },
                    { 27, "Tampa Bay", "1998", "Florida", "Rays", "0" },
                    { 28, "Arlington", "1961", "Texas", "Rangers", "1" },
                    { 29, "Toronto", "1976", "Ontario", "Blue Jays", "2" },
                    { 30, "Washington", "1859", "DC", "Nationals", "1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaseballTeams");
        }
    }
}
