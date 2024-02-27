using System.ComponentModel.DataAnnotations.Schema;

namespace Tournament.DAL.Models
{
    [Table("Teams")]
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Draws { get; set; }
        public int GoalsScored { get; set; }
        public int GoalsConceded { get; set; }

        public List<Player> Players { get; set; }
        public List<Match> Matches1 { get; set; }
        public List<Match> Matches2 { get; set; }
    }
}
