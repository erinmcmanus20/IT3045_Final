



using System.Collections.Generic;
using IT3045_Final.Interfaces;
using IT3045_Final.Models;

namespace IT3045_Final.Interfaces
{
    public interface ITeamMemberContextDAO
    {
        List<TeamMember> GetAllMembers();
        TeamMember GetMemberById(int id);
        TeamMember RemoveMemberById(int id);

        TeamMember UpdateMember(TeamMember member);

        TeamMember AddMember(TeamMember member);
        
    }
}