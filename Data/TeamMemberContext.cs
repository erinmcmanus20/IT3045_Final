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

                new TeamMember {Id = 1, FullName = "Erin McManus", Birthdate = "4/10/2004", Program = "Mechanical Engineering", Year = "Sophmore"}
            );
        }
    }
}