using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.applicationCore
{
    public class Plane
    {
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlaneId { get; set; }
         public PlaneType Planetype { get; set; }
        public List<Flight> Flights { get; set; }
        public override string ToString()
        {
            return $"{Capacity},{ManufactureDate},{PlaneId},{Planetype},{Flights}";
        }
        public Plane()
        {

        }
        /*
        public Plane(PlaneType pt, int capacity, DateTime date)
        {
            this.Capacity = capacity ;
            this.ManufactureDate = date ;
            this.Planetype = pt ;
        }
        */
    }


    public enum PlaneType
    {
        Boing=0,
        Airbus=1
    }

}
