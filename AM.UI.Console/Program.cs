using AM.applicationCore;
using AM.applicationCore.Services;
using System.Security.Cryptography.X509Certificates;

namespace AM.UI.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////int? a = null;
            //string? nom= System.Console.ReadLine();
            //System.Console.WriteLine("Bonjour "+nom);
            //int ageValue=-1;
            //while (ageValue == -1)
            //{
            //    var age = System.Console.ReadLine();
            //    int.TryParse(age, out ageValue);
            //}
            /*do
            {
                var age = System.Console.ReadLine();
                int.TryParse(age, out ageValue);
            } while (ageValue == -1);
            System.Console.WriteLine(ageValue + 1);
            Personne p = new Personne();
            p.Nom = "4twin8";
            System.Console.WriteLine(p);
            p.Login("asma", "asma");
            p.Login("asma", "asma@gmail", "asma");
            Personne e=new Etudiant();
            e.GetMyType();
            p.GetMyType();
            p.Email = "emaiaiiaia";
            p.Nom = "asma";

            //Personne p1= new Personne(1,"asma", "asma", DateTime.Now,"asma","asma","asma", "asma");
            Personne p2 = new Personne()
            {
                Id = 1,
                Nom = "amsma",
                Prenom="asma",
                ConfirmPassword="asma",
                Password="asma",
                DateNai=new DateTime(2020,12,25),
                Email="email"
            }; // madech testhakk el constructeur param 
            System.Console.WriteLine(p2);*/




            //Plane plane = new Plane();
            //plane.PlaneId = 0;
            //plane.Capacity = 0;
            //plane.ManufactureDate = DateTime.Now;
            //plane.Capacity = 10;

            //System.Console.WriteLine("q7=" + plane);

            //q 9
            /*
            Plane plane2 = new Plane(0, 10, DateTime.Now);
            System.Console.WriteLine("q8=" + plane2); */
            //Plane plane3 = new Plane
            //{
            //    Planetype = PlaneType.Airbus,
            //    Capacity = 150,
            //    ManufactureDate = new DateTime(2015, 02, 03)
            //};

            //ServiceFlight sf = new ServiceFlight();

            /// partie 2 
            /// 
            //        var flights = new List<Flight>
            //{
            //    new Flight { Destination = "Paris", Departure = "New York", FightDate = new DateTime(2023, 03, 01), FlightId = 1, EffectiveArrival = new DateTime(2023, 03, 01, 16, 30, 0), EstimatedDuration = 8, Planee = plane },
            //    new Flight { Destination = "Tokyo", Departure = "Los Angeles", FightDate = new DateTime(2023, 03, 05), FlightId = 2, EffectiveArrival = new DateTime(2023, 03, 06, 5, 30, 0), EstimatedDuration = 12, Planee = plane },
            //    new Flight { Destination = "New York", Departure = "Paris", FightDate = new DateTime(2023, 03, 07), FlightId = 3, EffectiveArrival = new DateTime(2023, 03, 07, 13, 0, 0), EstimatedDuration = 7, Planee =plane },
            //    new Flight { Destination = "London", Departure = "Los Angeles", FightDate = new DateTime(2023, 03, 10), FlightId = 4, EffectiveArrival = new DateTime(2023, 03, 11, 7, 30, 0), EstimatedDuration = 10, Planee = plane },
            //    new Flight { Destination = "Hong Kong", Departure = "Sydney", FightDate = new DateTime(2023, 03, 15), FlightId = 5, EffectiveArrival = new DateTime(2023, 03, 15, 23, 0, 0), EstimatedDuration = 10, Planee = plane },
            //    new Flight { Destination = "Sydney", Departure = "Hong Kong", FightDate = new DateTime(2023, 03, 18), FlightId = 6, EffectiveArrival = new DateTime(2023, 03, 19, 6, 30, 0), EstimatedDuration = 9, Planee = plane }
            //};
            //        var destination = "Paris";
            //        var dates = sf.GetFlightDatesa(destination);
            //        System.Console.WriteLine($"Dates of flights to {destination}:");
            //        foreach (var date in dates)
            //        {
            //            System.Console.WriteLine(date.ToShortDateString());
            //        }

            //    }
            //    int x = 10;
            //  x.add(10);

            // add flight 
           var am = new AmContext();
            //am.Flights.Add(new Flight()
            //{
            //    Departure = "Tunis",
            //    Destination = "Sousse",
            //    FightDate = new DateTime(22, 2, 2),
            //    EffectiveArrival = DateTime.Now,
            //    EstimatedDuration = 1,
            //    Planee = new Plane()
            //    {
            //        Capacity = 15,
            //        ManufactureDate = DateTime.Now,
            //        Planetype = PlaneType.Boing
            //    }
            //});
            /*
            foreach (var item in am.Flights.ToList())
            {
                System.Console.WriteLine(" affiche item "+item.FlightId+item.Planee.Capacity);
            }
            am.SaveChanges();
            */

        }
    
    }
}