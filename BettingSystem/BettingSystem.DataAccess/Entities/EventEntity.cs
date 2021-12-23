using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BettingSystem.DataAccess.Entities
{
    public class EventEntity
    {
        [Key]
        public int EventId { get; set; }

       
        public string Name { get; set; }

      
        public int ID { get; set; }

        public bool IsLive { get; set; }

        
        public int CategoryID { get; set; }

       
        public ICollection<MatchEntity> Matches { get; set; }
    }
}