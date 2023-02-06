using AM.applicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        //q8
        public void GetFlights(string filterType, string filterValue)
        {
            PropertyInfo property = typeof(Flight).GetProperty(filterType);
            if (property == null)
            {
                Console.WriteLine("Invalid filter type");
                return;
            }

            var filteredFlights = flights.Where(f => property.GetValue(f, null).ToString() == filterValue);
            foreach (var flight in filteredFlights)
            {
                Console.WriteLine(flight.ToString());
            }
        }
    }
}
