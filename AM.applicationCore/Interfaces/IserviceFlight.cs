using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.applicationCore.Interfaces
{
    public class IserviceFlight
    {
        public delegate void FlightDetailsDel(Plane plane);
        public delegate double DurationAverageDel(string destination);
    }
}
