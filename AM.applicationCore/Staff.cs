using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.applicationCore
{
    public class Staff:Passenger
    {
        public DateTime EmployementDate { get; set; }
        public string function  { get; set; }

        public int Salary { get; set; }


        public override string ToString()
        {
            return base.ToString() + EmployementDate + " " + function + " " + Salary;
        }

        public override void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine("and I'm a staff member");
        }


    }
}
