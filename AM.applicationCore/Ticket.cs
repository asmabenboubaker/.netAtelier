using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.applicationCore
{
    public class Ticket
    {
        [ ForeignKey("passenger")]
        public int PassengerFK { get; set; } //prop cle etrangere
        [ForeignKey("flight")]
        public int FlightFK { get; set; } // prop cle etrangere
        public double Prix { get; set; }
        public string Siege { get; set; }
        public bool VIP { get; set; }
        //relation many to many

        public virtual Flight flight { get; set; }
        public virtual Passenger passenger { get; set; }
        
    }
}