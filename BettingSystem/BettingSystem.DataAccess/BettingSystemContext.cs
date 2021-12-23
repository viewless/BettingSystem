using BettingSystem.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace BettingSystem.DataAccess
{
    public class BettingSystemContext : DbContext
    {
        public BettingSystemContext(DbContextOptions<BettingSystemContext> options)
          : base(options) { }

        public DbSet<BetEntity> Bets{ get; set; }

        public DbSet<EventEntity> Events{ get; set; }

        public DbSet<MatchEntity> Matches{ get; set; }

        public DbSet<OddEntity> Odds{ get; set; }

        public DbSet<XmlSportsEntity> XmlSports{ get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
        }

    }
}
