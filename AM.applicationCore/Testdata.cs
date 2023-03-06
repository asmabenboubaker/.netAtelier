using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.applicationCore
{
    public static class Testdata
    {
        public static List<Plane> Planes
        {
            get
            {
                return new List<Plane>() { new Plane() {

            Planetype=PlaneType.Boing,
            Capacity=150,
            ManufactureDate=new DateTime(2015,02,03)
            } ,
             new Plane() {

            Planetype=PlaneType.Airbus,
            Capacity=250,
            ManufactureDate=new DateTime(2020,11,11)
            }
                };
            }
        }

        public static List<Staff> Staffs
        {


            get
            {
                return new List<Staff>()
                {
                    new Staff()
                    {/*
                        FirstName="Caption",
                        LastName="Caption",*/
                        EmailAdress="caption.cap@gmail.com",
                        BirthDate=new DateTime(1999,01,001),
                        Salary=9999
                    }
                };
            }




        }

        public static List<Traveller> travellers
        {
            get
            {
                return new List<Traveller>()
            {
                new Traveller()
                {/*
                    FirstName="travller1",
                    LastName="traveller1",*/
                    EmailAdress="traveller@gmail.com",
                BirthDate=new DateTime(1980,12,12),
                Nationality="American"
                }
            };

            }
        }

        public static List< Flight> flights
        {
            get
            {
                return new List<Flight>()
                {
                    new Flight()
                    {
                        FightDate=new DateTime(2022,01,01,15,10,10)
                    }
                };
            }
        }
    }

}
