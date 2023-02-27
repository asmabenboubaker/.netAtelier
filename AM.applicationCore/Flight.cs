using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.applicationCore
{
   // [(Table="vols")]
    public class Flight
    {
        public string Destination { get; set; }

        public string Departure { get; set; }
        public DateTime FightDate { get; set; }

        public int FlightId { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public int EstimatedDuration { get; set; }
        //[ForeignKey("PlaneId")] ou 
        public Plane? Planee { get; set; }
        [ForeignKey("Plane")]
        public int? PlaneId { get; set; }//prop cle etrangere 
        public List<Passenger> Passengers { get; set; }


        public override string ToString()
        {
            return $"{Destination},{Departure},{FightDate},{FlightId},{EffectiveArrival},{EstimatedDuration},{Planee},{Passengers}";
        }
    }
}
