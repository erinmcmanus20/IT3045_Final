namespace IT3045_Final.Models
{
  public class StudentSports
  {
      public int Id { get; set; }
      public int StudentId? { get; set; }  
      public string SportName? { get; set; }
      public string Position? { get; set; }
      public int YearJoined? { get; set; }
      
  }
}