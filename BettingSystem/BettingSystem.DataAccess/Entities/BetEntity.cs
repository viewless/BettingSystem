using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BettingSystem.DataAccess.Entities
{
    public class BetEntity
    {
        [Key]
        public int BetId { get; set; }
      
        public string Name { get; set; }
        public int ID { get; set; }
        public bool IsLive { get; set; }
        public ICollection<OddEntity> Odds { get; set; }
    }
}