using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BettingSystem.DataAccess.Entities
{
    public class SportEntity
    {
        [Key]
        public int SportId { get; set; }
        public string Name { get; set; }
        public int ID { get; set; }
        public ICollection<EventEntity> Events{ get; set; }
    }
}