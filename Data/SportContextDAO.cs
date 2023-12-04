
using System.Collections.Generic;
using System.Runtime.InteropServices;
using IT3045_Final.Interfaces;
using IT3045_Final.Models;

namespace IT3045_Final.Data
{
    public class SportsContextDAO : SportsContextInterfaceDAO
    {
        private SportsContextDAO _context;

        public SportsContextDAO(SportsContext context)
        {
            _context = context;
        }

        public List<Sports> GetAllTeamMembers()
        {
            return _context.SportsTeamMember.ToList();
        }

        public Sports GetTeamMemberById(int id)
        {
            return _context.SportsTeamMember.Where(x => x.Id.Equals(id)).FirstOrDefault();

        }

        public Sports RemoveTeamMemberById(int id)
        {
            var member = this.GetTeamMemberById(id);
            if (member == null) 
                return null;
            try
            {
                _context.SportsTeamMember.Remove(member);
                _context.SaveChanges();
                return member;
            }

            catch(Exception)
            {
                return null;
            }
        }

        public Sports UpdateTeamMember(Sports member)
        {
            var memberToUpdate = this.GetSportsMemberById((int)member.Id);
            if (memberToUpdate == null) 
                return null;
            
            if (!member.Birthdate.Equals("string"))
                memberToUpdate.Birthdate = member.Birthdate;
            if (!member.TeamMemberName.Equals("string"))
                memberToUpdate.TeamMemberName = member.TeamMemberName;
            if (!member.SportsName.Equals("string"))
                memberToUpdate.SportsName = member.SportsName;
            if (!member.NoOfMatchesPlayed.Equals("string"))
                memberToUpdate.NoOfMatchesPlayed = member.NoOfMatchesPlayed;

            

            try
            {
                _context.SportsTeamMember.Update(memberToUpdate);
                _context.SaveChanges();
                return memberToUpdate;
            
            }

            catch(Exception)
            {
                return null;
            }
            
        }

        public Sports AddTeamMember(Sports member)
        {
            var match = _context.SportsTeamMember.Where(x=> x.TeamMemberName.Equals(member.TeamMemberName) && x.Birthdate.Equals(member.Birthdate)).FirstOrDefault();
            

            if (match != null)
                return null;

            try
            {
                var newMember = new Sports{
                    TeamMemberName = member.TeamMemberName,
                    Birthdate = member.Birthdate,
                    NoOfMatchesPlayed = member.NoOfMatchesPlayed,
                    SportsName = member.SportsName

                };
                _context.SportsTeamMember.Add(newMember);
                Console.WriteLine("added new team member");
                _context.SaveChanges();
                return member;

            }
            catch(Exception)
            {
                Console.WriteLine("Caught Exception");
                return null;
            }
        }
    }


}