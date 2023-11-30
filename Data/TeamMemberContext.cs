using IT3045_Final.Models;
using Microsoft.EntityFrameworkCore;

namespace IT3045_Final.Data
{
    public class TeamMemberContext : DbContext
    {
        public TeamMemberContext(DbContextOptions<TeamMemberContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TeamMember>().HasData(

                new TeamMember {Id = 1, FullName = "Erin McManus", Birthdate = "4/10/2004", Program = "Mechanical Engineering", Year = "2nd"},
                new TeamMember {Id = 2, FullName = "Nivedha Balasubramanian", Birthdate = " ", Program = " ", Year = " "},
                new TeamMember {Id = 3, FullName = "Josh Moore", Birthdate = "6/30/1994", Program = "IT Software Development", Year = "N/A"},
                new TeamMember {Id = 4, FullName = "Noah Wardega", Birthdate = "6/5/2003", Program = "Certificate in IT", Year = "3rd"}
            );
        }

        public DbSet<TeamMember> TeamMembers { get; set; }
    }
}