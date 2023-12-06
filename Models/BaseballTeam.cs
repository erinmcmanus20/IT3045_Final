namespace IT3045_Final.Models
{
    public class BaseballTeam
    {
        public int? Id { get; set; }
        public string? TeamName { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }

        public string? Founded { get; set; }

        public string? WorldSeriesChampionships { get; set; }
    }
}