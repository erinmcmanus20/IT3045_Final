
using System.Collections.Generic;
using IT3045_Final.Interfaces;
using IT3045_Final.Models;

namespace IT3045_Final.Interfaces
{
    public interface SportsContextInterfaceDAO
    {
        List<Sports> GetAllTeamMembers();

        Sports GetTeamMemberById(int id);
        Sports DeleteSports(int id);

        Sports UpdateTeamMember(Sports member);

        Sports AddTeamMember(Sports member);
        
    }
}