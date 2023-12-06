using IT3045_Final.Models;
using Microsoft.EntityFrameworkCore;

namespace IT3045_Final.Data
{
    public class BaseballTeamContext : DbContext
    {
        public BaseballTeamContext(DbContextOptions<BaseballTeamContext> options) : base(options) {}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            Console.Write("Baseball Teams");
            builder.Entity<BaseballTeam>().HasData(

                new BaseballTeam { Id = 1, TeamName = "Diamondbacks", City = "Phoenix", State = "Arizona", Founded = "1998", WorldSeriesChampionships = "1" },
                new BaseballTeam { Id = 2, TeamName = "Braves", City = "Atlanta", State = "Georgia", Founded = "1871", WorldSeriesChampionships = "4" },
                new BaseballTeam { Id = 3, TeamName = "Orioles", City = "Baltimore", State = "Maryland", Founded = "1894", WorldSeriesChampionships = "3" },
                new BaseballTeam { Id = 4, TeamName = "Red Sox", City = "Boston", State = "Massachusetts", Founded = "1901", WorldSeriesChampionships = "9" },
                new BaseballTeam { Id = 5, TeamName = "Cubs", City = "Chicago", State = "Illinois", Founded = "1876", WorldSeriesChampionships = "3" },
                new BaseballTeam { Id = 6, TeamName = "White Sox", City = "Chicago", State = "Illinois", Founded = "1901", WorldSeriesChampionships = "3" },
                new BaseballTeam { Id = 7, TeamName = "Reds", City = "Cincinnati", State = "Ohio", Founded = "1881", WorldSeriesChampionships = "5" },
                new BaseballTeam { Id = 8, TeamName = "Guardians", City = "Cleveland", State = "Ohio", Founded = "1894", WorldSeriesChampionships = "2" },
                new BaseballTeam { Id = 9, TeamName = "Rockies", City = "Denver", State = "Colorado", Founded = "1991", WorldSeriesChampionships = "0" },
                new BaseballTeam { Id = 10, TeamName = "Tigers", City = "Detroit", State = "Michigan", Founded = "1894", WorldSeriesChampionships = "4" },
                new BaseballTeam { Id = 11, TeamName = "Astros", City = "Houston", State = "Texas", Founded = "1962", WorldSeriesChampionships = "2" },
                new BaseballTeam { Id = 12, TeamName = "Royals", City = "Kansas City", State = "Missouri", Founded = "1969", WorldSeriesChampionships = "2" },
                new BaseballTeam { Id = 13, TeamName = "Angels", City = "Anaheim", State = "California", Founded = "1961", WorldSeriesChampionships = "1" },
                new BaseballTeam { Id = 14, TeamName = "Dodgers", City = "Los Angeles", State = "California", Founded = "1883", WorldSeriesChampionships = "7" },
                new BaseballTeam { Id = 15, TeamName = "Marlins", City = "Miami", State = "Florida", Founded = "1991", WorldSeriesChampionships = "2" },
                new BaseballTeam { Id = 16, TeamName = "Brewers", City = "Milwaukee", State = "Wisconsin", Founded = "1969", WorldSeriesChampionships = "0" },
                new BaseballTeam { Id = 17, TeamName = "Twins", City = "Minneapolis", State = "Minnesota", Founded = "1901", WorldSeriesChampionships = "3" },
                new BaseballTeam { Id = 18, TeamName = "Mets", City = "Flushing", State = "New York", Founded = "1962", WorldSeriesChampionships = "2" },
                new BaseballTeam { Id = 19, TeamName = "Yankees", City = "Bronx", State = "New York", Founded = "1903", WorldSeriesChampionships = "27" },
                new BaseballTeam { Id = 20, TeamName = "Athletics", City = "Oakland", State = "California", Founded = "1901", WorldSeriesChampionships = "9" },
                new BaseballTeam { Id = 21, TeamName = "Phillies", City = "Philadelphia", State = "Pennsylvania", Founded = "1883", WorldSeriesChampionships = "2" },
                new BaseballTeam { Id = 22, TeamName = "Pirates", City = "Pittsburgh", State = "Pennsylvania", Founded = "1882", WorldSeriesChampionships = "5" },
                new BaseballTeam { Id = 23, TeamName = "Padres", City = "San Diego", State = "California", Founded = "1969", WorldSeriesChampionships = "0" },
                new BaseballTeam { Id = 24, TeamName = "Giants", City = "San Francisco", State = "California", Founded = "1883", WorldSeriesChampionships = "8" },
                new BaseballTeam { Id = 25, TeamName = "Mariners", City = "Seattle", State = "Washington", Founded = "1977", WorldSeriesChampionships = "0" },
                new BaseballTeam { Id = 26, TeamName = "Cardinals", City = "St. Louis", State = "Missouri", Founded = "1882", WorldSeriesChampionships = "11" },
                new BaseballTeam { Id = 27, TeamName = "Rays", City = "Tampa Bay", State = "Florida", Founded = "1998", WorldSeriesChampionships = "0" },
                new BaseballTeam { Id = 28, TeamName = "Rangers", City = "Arlington", State = "Texas", Founded = "1961", WorldSeriesChampionships = "1" },
                new BaseballTeam { Id = 29, TeamName = "Blue Jays", City = "Toronto", State = "Ontario", Founded = "1976", WorldSeriesChampionships = "2" },
                new BaseballTeam { Id = 30, TeamName = "Nationals", City = "Washington", State = "DC", Founded = "1859", WorldSeriesChampionships = "1" }
            );

        }

        public DbSet<BaseballTeam> BaseballTeams { get; set;}
    }
}