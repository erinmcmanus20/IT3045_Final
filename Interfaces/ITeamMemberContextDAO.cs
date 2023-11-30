



using System.Collections.Generic;
using IT3045_Final.Interfaces;
using IT3045_Final.Models;

namespace IT3045_Final.Interfaces
{
    public interface ITeamMemberContextDAO
    {
        List<TeamMember> GetAllMembers();
    }
}