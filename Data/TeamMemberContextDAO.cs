
using System.Collections.Generic;
using System.Runtime.InteropServices;
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
                _context.SaveChanges();
                return member;
            }

            catch(Exception)
            {
                return null;
            }
        }

        public TeamMember UpdateMember(TeamMember member)
        {
            var memberToUpdate = this.GetMemberById(member.Id);
            if (memberToUpdate == null) 
                return null;
            
            if (!member.Birthdate.Equals("string"))
                memberToUpdate.Birthdate = member.Birthdate;
            if (!member.FullName.Equals("string"))
                memberToUpdate.FullName = member.FullName;
            if (!member.Program.Equals("string"))
                memberToUpdate.Program = member.Program;
            if (!member.Year.Equals("string"))
                memberToUpdate.Year = member.Year;

            

            try
            {
                _context.TeamMembers.Update(memberToUpdate);
                _context.SaveChanges();
                return memberToUpdate;
            
            }

            catch(Exception)
            {
                return null;
            }
            
        }

        public TeamMember AddMember(TeamMember member)
        {
            var match = _context.TeamMembers.Where(x=> x.FullName.Equals(member.FullName) && x.Birthdate.Equals(member.Birthdate)).FirstOrDefault();
            

            if (match != null)
                return null;

            try
            {
                var newMember = new TeamMember{
                    FullName = member.FullName,
                    Birthdate = member.Birthdate,
                    Year = member.Year,
                    Program = member.Program

                };
                _context.TeamMembers.Add(newMember);
                Console.WriteLine("added member");
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

