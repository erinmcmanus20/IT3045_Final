using System.Collections.Generic;
using System.Runtime.InteropServices;
using IT3045_Final.Interfaces;
using IT3045_Final.Models;


namespace IT3045_Final.Data
{
    public class BaseballTeamContextDAO : IBaseballTeamContextDAO
    {
        private BaseballTeamContext _context;

        public BaseballTeamContextDAO(BaseballTeamContext context)
        {
            _context = context;
        }

        public List<BaseballTeam> GetAllTeams()
        {
            return _context.BaseballTeams.ToList();
        }

         public BaseballTeam GetTeamByID(int id)
        {
            return _context.BaseballTeams.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

          public BaseballTeam RemoveTeamByID(int id)
        {
            var team = this.GetTeamByID(id);
            if (team == null)
             return null;
            try
            {
                _context.BaseballTeams.Remove(team);
                _context.SaveChanges();
                return team;
            }
            catch(Exception)
            {
                return null;
            }
        }

        public BaseballTeam UpdateTeam(BaseballTeam team)
        {
            var teamToUpdate = this.GetTeamByID((int)team.Id);
            if (teamToUpdate == null)
                return null;

            if (!team.TeamName.Equals("string"))
                teamToUpdate.TeamName = team.TeamName;
            if (!team.City.Equals("string"))
                teamToUpdate.City = team.City;
            if (!team.State.Equals("string"))
                teamToUpdate.State = team.State;
            if (!team.WorldSeriesChampionships.Equals("string"))
                teamToUpdate.State = team.WorldSeriesChampionships;

            try
            {
                _context.BaseballTeams.Update(teamToUpdate);
                _context.SaveChanges();
                return teamToUpdate;
            }
            catch(Exception)
            {
                return null;
            }
        }
        
        public BaseballTeam AddTeam(BaseballTeam team)
        {
            var match = _context.BaseballTeams.Where(x => x.City.Equals(team.City) && x.TeamName.Equals(team.TeamName)).FirstOrDefault();

            if (match !=null)
                return null;

            try
            {
                var newTeam = new BaseballTeam{
                    City = team.City,
                    TeamName = team.TeamName,
                    State = team.State,
                    WorldSeriesChampionships = team.WorldSeriesChampionships

                };
                _context.BaseballTeams.Add(newTeam);
                Console.WriteLine("added team");
                _context.SaveChanges();
                return team;
            }
            catch(Exception)
            {
                Console.WriteLine("Caught Exception");
                return null;
            }
        }

        public BaseballTeam RemoveTeamById(int id)
        {
            throw new NotImplementedException();
        }
    }
}