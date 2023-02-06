using AM.applicationCore;
using AM.applicationCore.Services;

namespace AM.UI.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int? a = null;
            string? nom= System.Console.ReadLine();
            System.Console.WriteLine("Bonjour "+nom);
            int ageValue=-1;
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




            Plane plane = new Plane();
            plane.PlaneId = 0;
            plane.Capacity = 0;
            plane.ManufactureDate = DateTime.Now;
            plane.Capacity = 10;

            System.Console.WriteLine("q7=" + plane);

            //q 9
            /*
            Plane plane2 = new Plane(0, 10, DateTime.Now);
            System.Console.WriteLine("q8=" + plane2); */
            Plane plane3 = new Plane
            {
                Planetype = PlaneType.Airbus,
                Capacity = 150,
                ManufactureDate = new DateTime(2015, 02, 03)
            };

            ServiceFlight sf = new ServiceFlight();

        }
    }
}