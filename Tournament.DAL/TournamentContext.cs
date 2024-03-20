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
        public async Task<List<Team>> SearchTeamsByName(string teamName)
        {
            return await Teams.Where(t => t.Name == teamName).ToListAsync();
        }

        public async Task<List<Team>> SearchTeamsByCity(string city)
        {
            return await Teams.Where(t => t.City == city).ToListAsync();
        }

        //Display

        public async Task<Team> GetTeamWithMostWins()
        {
            return await Teams.OrderByDescending(t => t.Wins).FirstOrDefaultAsync();
        }

        public async Task<Team> GetTeamWithMostLosses()
        {
            return await Teams.OrderByDescending(t => t.Losses).FirstOrDefaultAsync();
        }

        public async Task<Team> GetTeamWithMostDraws()
        {
            return await Teams.OrderByDescending(t => t.Draws).FirstOrDefaultAsync();
        }

        public async Task<Team> GetTeamWithMostGoalsScored()
        {
            return await Teams.OrderByDescending(t => t.GoalsScored).FirstOrDefaultAsync();
        }

        public async Task<Team> GetTeamWithMostGoalsConcededAsync()
        {
            return await Teams.OrderByDescending(t => t.GoalsConceded).FirstOrDefaultAsync();
        }


    }
}

