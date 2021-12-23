using System;

namespace BettingSystem.Models.ResponseModels
{
    public class MatchResponse
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public string MatchType { get; set; }
        public BetResponse Bets { get; set; }
    }
}
