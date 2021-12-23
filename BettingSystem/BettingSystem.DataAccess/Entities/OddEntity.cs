using System.ComponentModel.DataAnnotations;

namespace BettingSystem.DataAccess.Entities
{
    public class OddEntity
    {
        [Key]
        public int OddId { get; set; }
        public string Name { get; set; }
        public int ID { get; set; }
        public double Value { get; set; }
        public double? SpecialBetValue { get; set; }
    }
}