using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.applicationCore.Services
{
    public static class PassengerExtension
    {
        public static void FullNamePassenger(this Passenger passenger)
        {
            passenger.FirstName= passenger.FirstName[0].ToString().ToUpper()+passenger.FirstName.ToUpper().Substring(1);
            passenger.LastName= passenger.LastName[0].ToString().ToUpper()+passenger.LastName.ToUpper().Substring(1);


        }
    }
}
