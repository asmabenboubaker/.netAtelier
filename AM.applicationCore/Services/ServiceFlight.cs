using AM.applicationCore.Interfaces;
using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static AM.applicationCore.Interfaces.IserviceFlight;

namespace AM.applicationCore.Services
{

    public class ServiceFlight : Service<Flight>, IserviceFlight 
    {
        public ServiceFlight(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        //    public readonly IUnitOfWork uow;

        //    public ServiceFlight(IUnitOfWork uow)
        //    {
        //        this.uow=uow;
        //    }
        //    public void Add(Flight flight)
        //    {
        //        uow.Repository<Flight>().Add(flight);
        //        uow.Save();
        //    }
        //    public void Update(Flight flight)
        //    {
        //        uow.Repository<Flight>().Update(flight);
        //        uow.Save();
        //    }
        //    public IList<Flight> GetAll()
        //    {
        //        return uow.Repository<Flight>().GetAll().ToList();
        //    }

        //    /*
        //    List<DateTime> GetFlightDates(String destination)
        //        {
        //            List<DateTime> dates = new List<DateTime>();
        //            for(int i = 0; i < flights.Count; i++)
        //            {
        //                Flight flight = flights[i];
        //                if(flight.Destination == destination)
        //                {
        //                    dates.Add(flight.FightDate);

        //                }
        //                return dates;
        //            }
        //        }*/
        //    /*
        //    IEnumerable<DateTime> GetFlightDates(string destination)
        //    {
        //        // IEnumerable<DateTime> dates = new List<DateTime>();
        //        for (int i = 0; i < flights.Count; i++)
        //        {
        //            Flight flight = flights[i];
        //            if (flight.Destination == destination)
        //            {
        //                yield return flight.FightDate;

        //            }

        //        }
        //    }*/

        //    IEnumerable<DateTime> GetFlightDates(string destination)
        //    {
        //         foreach (var flight in flights)
        //        {
        //            if (flight.Destination == destination)
        //            {
        //                yield return flight.FightDate;

        //            }
        //        }
        //    }
        //    //q8
        //    public void GetFlights(string filterType, string filterValue)
        //    {
        //        PropertyInfo property = typeof(Flight).GetProperty(filterType);
        //        if (property == null)
        //        {
        //            Console.WriteLine("Invalid filter type");
        //            return;
        //        }

        //        var filteredFlights = flights.Where(f => property.GetValue(f, null).ToString() == filterValue);
        //        foreach (var flight in filteredFlights)
        //        {
        //            Console.WriteLine(flight.ToString());
        //        }
        //    }
        //    //q9
        //    public List<DateTime> GetFlightDatesa(string destination)
        //    {

        //        var query = from flight in flights
        //                    where flight.Destination == destination
        //                    select flight.FightDate;

        //        return query.ToList();
        //    }
        //    //q10
        //    public void ShowFlightDetails(Plane plane)
        //    {

        //        var query = from flight in flights
        //                    where flight.Planee == plane
        //                    select new { flight.Destination, flight.FightDate };

        //        foreach (var flightdetail in query)
        //        {
        //            Console.WriteLine($"{flightdetail.Destination} - {flightdetail.FightDate}");
        //        }
        //    }
        //    //q11
        //    public static int ProgrammedFlightNumber(List<Flight> flights, DateTime startDate)
        //    {
        //        DateTime endDate = startDate.AddDays(7);

        //        int count = flights.Count(flight =>
        //            flight.FightDate >= startDate &&
        //            flight.FightDate < endDate);

        //        return count;
        //    }
        //    //q12
        //    public static double DurationAverage( string destination)

        //    {
        //        List<Flight> flights=new List<Flight>();
        //        var duration = from flight in flights
        //                            where flight.Destination == destination
        //                            select flight.EstimatedDuration;

        //        double averageDuration = duration.Average();

        //        return averageDuration;
        //    }
        //    //q13
        //    public static List<Flight> OrderedDurationFlights(List<Flight> flights)
        //    {
        //        var orderedFlights = from flight in flights
        //                             orderby flight.EstimatedDuration descending
        //                             select flight;

        //        return orderedFlights.ToList();
        //    }
        //    //q14
        //    /*
        //    public List<Passenger> SeniorTravellers(Flight flight)
        //    {

        //        return flight.Passengers
        //            .OfType<Traveller>()
        //            .OrderBy(t => t.BirthDate)
        //            .Take(3)
        //            .Cast<Passenger>()
        //            .ToList();
        //}*/

        ////q15
        //public void DestinationGroupedFlights()
        //    {
        //        var groups = flights.GroupBy(flight => flight.Destination);

        //        foreach (var group in groups)
        //        {
        //            Console.WriteLine("Destination " + group.Key);

        //            foreach (var flight in group)
        //            {
        //                Console.WriteLine("Décollage : " + flight.FightDate.ToString("dd/MM/yyyy HH:mm:ss"));
        //            }
        //        }
        //    }
        //    //q17 

        //    private Action<Plane> flightDetailsDel { get; set; }
        //    private Func<String, double> durationAverageDel { get; set; }

        //    public List<Flight> flights { get; set; } = new List<Flight>();
        //    public ServiceFlight()
        //    {
        //        /*  flightDetailsDel = ShowFlightDetails;
        //          durationAverageDel = DurationAverage;*/

        //        flightDetailsDel = plane =>
        //        {

        //            var query = from flight in flights
        //                        where flight.Planee == plane
        //                        select new { flight.Destination, flight.FightDate };

        //            foreach (var flightdetail in query)
        //            {
        //                Console.WriteLine($"{flightdetail.Destination} - {flightdetail.FightDate}");
        //            }
        //        };
        //        durationAverageDel =  destination=>
        //        {
        //            List<Flight> flights = new List<Flight>();
        //            var duration = from flight in flights
        //                           where flight.Destination == destination
        //                           select flight.EstimatedDuration;

        //            double averageDuration = duration.Average();

        //            return averageDuration;
        //        };


        //    }
        //public IList<Flight> GetFlight(int n)
        //{
        //   return GetAll().OrderByDescending(p=>p.PlaneId).Take(n).SelectMany(p=>p.Flights).OrderBy(f=>f.)
        //}

        public IEnumerable<Flight> GetMany(Expression<Func<Flight, bool>> where)
        {
            throw new NotImplementedException();
        }

        public void Update(Flight entity)
        {
            throw new NotImplementedException();
        }
    }
}
