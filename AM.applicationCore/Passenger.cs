using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AM.applicationCore
{
    public class Passenger
    {
        public int PassengerId { get; set; }
        public DateTime BirthDate { get; set; }
        public int PassportNumber { get; set; }

        public string EmailAdress { get; set;}
        public String FirstName { get; set; }
        public string LastName { get; set; }

        public int TelNumber { get; set; }

        public List<Flight> flights { get; set; }

        public override string ToString()
        {
            return $" {BirthDate},{PassportNumber},{EmailAdress},{FirstName},{LastName},{TelNumber}";
        }
        /*  // q a 
        public bool CheckProfile(string firstName, string lastName)
        {
            return this.FirstName == firstName && this.LastName == lastName;
        }
        /// q b
        public bool CheckProfile(string firstName, string lastName, string email)
        {
            return this.FirstName == firstName && this.LastName == lastName && this.EmailAdress == email;
        }
        */
        //q c 
        public bool CheckProfile(string firstName, string lastName, string email = null)
        {
            if (email != null)
                return FirstName == firstName && LastName == lastName &&
               EmailAdress == email;
            else
                return FirstName == firstName && LastName == lastName;
        }
        // q 11 a
        public virtual void PassengerType()
        {
            Console.WriteLine("I am a Passenger");
        }


    }

}
