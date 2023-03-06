using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;

namespace AM.applicationCore
{
    public class Passenger
    {
        public int PassengerId { get; set; }
        //[DisplayName("day of birth")] ou 
        [Display(Name= "day of birth"), DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Key, StringLength(7)] 
        public int PassportNumber { get; set; }

        [EmailAddress]
        //[DataType(DataType.EmailAddress)] 
        public string EmailAdress { get; set;}
       

       
        public FullName fullname;
        /*  [MinLength(3, ErrorMessage = ">3"), MaxLength(25, ErrorMessage = "<25")]
         * public String FirstName { get; set; }
         public string LastName { get; set; }*/
        //[0-9]{,8} => 1,2 ..8
        //[0-9]{8,} => 8..... 

        /*
         * 
         */
        [RegularExpression("[0-9]{8}")]
        public int TelNumber { get; set; }

        public List<Ticket> tickets { get; set; }

        public override string ToString()
        {
            return $" {BirthDate},{PassportNumber},{EmailAdress},{TelNumber}";
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
      /*  public bool CheckProfile(string firstName, string lastName, string email = null)
        {
            if (email != null)
                return FirstName == firstName && LastName == lastName &&
               EmailAdress == email;
            else
                return FirstName == firstName && LastName == lastName;
        }*/
        // q 11 a
        public virtual void PassengerType()
        {
            Console.WriteLine("I am a Passenger");
        }


    }

}
