using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BettingSystem.DataAccess.Entities
{
    public class MatchEntity
    {
        [Key]
        public int MatchId { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public string MatchType { get; set; }
        public ICollection<BetEntity> Bets { get; set; }
    }
}