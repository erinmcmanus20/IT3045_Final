using IT3045_Final.Models;
using Microsoft.EntityFrameworkCore;

namespace IT3045_Final.Data
{
    public class SportsContext : DbContext
    {
        public SportsContext(DbContextOptions<SportsContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            Console.Write("creating members");
            builder.Entity<Sports>().HasData(
                
                new Sports {Id = 1, TeamMemberName = "James Smith", SportsName = "Cricket", Birthdate = "12/1/2004", NoOfMatchesPlayed = "12"},
                new Sports {Id = 2, TeamMemberName = "Robert Johnson", SportsName = "Soccer", Birthdate = "2/10/2007", NoOfMatchesPlayed = "12"},
                new Sports {Id = 3, TeamMemberName = "Maria Garcia", SportsName = "BasketBall", Birthdate = "9/4/2008", NoOfMatchesPlayed = "12"},
                new Sports {Id = 4, TeamMemberName = "Taylor Miller", SportsName = "Hockey", Birthdate = "11/9/2005", NoOfMatchesPlayed = "12"},
                new Sports {Id = 5, TeamMemberName = "Davis Jones", SportsName = "Soccer", Birthdate = "6/12/2008", NoOfMatchesPlayed = "12"}
            );
        }

        public DbSet<Sports> SportsTeamMember { get; set; }
    }
}