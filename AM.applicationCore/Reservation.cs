using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.applicationCore
{
    public class Reservation
    {
        //[ForeignKey("seat")]
        public int SeatFK { get; set; }
       // [ForeignKey("passenger")]
        public int PassengerFK { get; set; }
        public DateTime DateReservation { get; set; }

        public virtual Seat seat { get; set; }
        public virtual Passenger passenger { get; set; }
    }
}
