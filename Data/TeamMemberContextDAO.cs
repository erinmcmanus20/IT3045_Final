
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

        public TeamMember GetMemberById(int id)
        {
            return _context.TeamMembers.Where(x => x.Id.Equals(id)).FirstOrDefault();

        }

        public TeamMember RemoveMemberById(int id)
        {
            var member = this.GetMemberById(id);
            if (member == null) 
                return null;
            try
            {
                _context.TeamMembers.Remove(member);
                return member;
            }

            catch(Exception e)
            {
                return null;
            }
        }
    }


}

