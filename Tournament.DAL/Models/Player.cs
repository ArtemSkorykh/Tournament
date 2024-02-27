namespace Tournament.DAL.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Country { get; set; }
        public int ShirtNumber { get; set; }
        public string Position { get; set; }

        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}
