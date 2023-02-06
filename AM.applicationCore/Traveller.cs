using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.applicationCore
{
    public class Traveller:Passenger
    {
        public string healthInformation { get; set; }
        public string Nationality { get; set; }

        public override string ToString()
        {
            return base.ToString() + healthInformation + " " + Nationality;
        }
        // q b 
        public override void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine("and I'm a traveller");
        }


    }
}
