using Microsoft.EntityFrameworkCore;
using Tournament.DAL.Models;

namespace Tournament.DAL
{
    public class TournamentDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Tournament;Integrated Security=True;Connect Timeout=30;");
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Match> Matches { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>()
                .HasOne(p => p.Team)
                .WithMany(t => t.Players)
                .HasForeignKey(p => p.TeamId);

            modelBuilder.Entity<Match>()
                .HasOne(m => m.Team1)
                .WithMany(t => t.Matches1)
                .HasForeignKey(m => m.Team1Id);

            modelBuilder.Entity<Match>()
                .HasOne(m => m.Team2)
                .WithMany(t => t.Matches2)
                .HasForeignKey(m => m.Team2Id);
        }

        //Search

        public List<Team> SearchTeamsByName(string teamName)
        {
            return Teams.Where(t => t.Name == teamName).ToList();
        }

        public List<Team> SearchTeamsByCity(string city)
        {
            return Teams.Where(t => t.City == city).ToList();
        }

        //Display

        public Team GetTeamWithMostWins()
        {
            return Teams.OrderByDescending(t => t.Wins).FirstOrDefault();
        }

        public Team GetTeamWithMostLosses()
        {
            return Teams.OrderByDescending(t => t.Losses).FirstOrDefault();
        }

        public Team GetTeamWithMostDraws()
        {
            return Teams.OrderByDescending(t => t.Draws).FirstOrDefault();
        }

        public Team GetTeamWithMostGoalsScored()
        {
            return Teams.OrderByDescending(t => t.GoalsScored).FirstOrDefault();
        }

        public Team GetTeamWithMostGoalsConceded()
        {
            return Teams.OrderByDescending(t => t.GoalsConceded).FirstOrDefault();
        }

       
    }
}

