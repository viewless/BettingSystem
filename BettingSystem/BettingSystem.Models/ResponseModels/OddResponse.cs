namespace BettingSystem.Models.ResponseModels
{
    public class OddResponse
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public double Value { get; set; }
        public double SpecialBetValue { get; set; }
    }
}