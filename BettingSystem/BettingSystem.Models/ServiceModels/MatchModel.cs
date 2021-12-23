using System;

namespace BettingSystem.Models.ServiceModels
{
    public class MatchModel
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public string MatchType { get; set; }
        public BetModel Bets { get; set; }
    }
}
