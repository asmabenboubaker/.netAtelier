using AM.applicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.applicationCore.Services
{
    public class ServiceFlight : IserviceFlight
    {
        public List<Flight> flights { get; set; } = new List<Flight>();
        /*
        List<DateTime> GetFlightDates(String destination)
            {
                List<DateTime> dates = new List<DateTime>();
                for(int i = 0; i < flights.Count; i++)
                {
                    Flight flight = flights[i];
                    if(flight.Destination == destination)
                    {
                        dates.Add(flight.FightDate);

                    }
                    return dates;
                }
            }*/
        /*
        IEnumerable<DateTime> GetFlightDates(string destination)
        {
            // IEnumerable<DateTime> dates = new List<DateTime>();
            for (int i = 0; i < flights.Count; i++)
            {
                Flight flight = flights[i];
                if (flight.Destination == destination)
                {
                    yield return flight.FightDate;

                }
                
            }
        }*/
       
        IEnumerable<DateTime> GetFlightDates(string destination)
        {
             foreach (var flight in flights)
            {
                if (flight.Destination == destination)
                {
                    yield return flight.FightDate;

                }
            }
        }
    }
}
