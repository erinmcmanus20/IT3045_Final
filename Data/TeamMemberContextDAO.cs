
using System.Collections.Generic;
using IT3045_Final.Interfaces;
using IT3045_Final.Models;

namespace IT3045_Final.Data
{
    public class TeamMemberContextDAO : ITeamMemberContextDAO
    {
        private TeamMemberContext _context;

        public TeamMemberContextDAO(TeamMemberContext context)
        {
            _context = context;
        }

        public List<TeamMember> GetAllMembers()
        {
            return _context.TeamMembers.ToList();
        }
    }


}

