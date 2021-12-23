using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BettingSystem.DataAccess.Entities
{
    public class XmlSportsEntity
    {
        [Key]
        public int XmlSportsId { get; set; }
        public DateTime CreateDate { get; set; }

        public SportEntity Sport{ get; set; }


    }
}
