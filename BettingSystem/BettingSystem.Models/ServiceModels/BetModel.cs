namespace BettingSystem.Models.ServiceModels
{
    public class BetModel
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public bool IsLive { get; set; }
        public OddModel Odd { get; set; }
    }
}