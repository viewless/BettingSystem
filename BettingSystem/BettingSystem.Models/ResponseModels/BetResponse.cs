namespace BettingSystem.Models.ResponseModels
{
    public class BetResponse
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public bool IsLive { get; set; }
        public OddResponse Odd { get; set; }
    }
}