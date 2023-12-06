using System.Collections.Generic;
using IT3045_Final.Interfaces;
using IT3045_Final.Models;

namespace IT3045_Final.Interfaces
{
    public interface IBaseballTeamContextDAO
    {
        List<BaseballTeam> GetAllTeams();

        BaseballTeam GetTeamByID(int id);

        BaseballTeam UpdateTeam(BaseballTeam team);

        BaseballTeam AddTeam(BaseballTeam team);

        BaseballTeam RemoveTeamById(int id);
    }
}