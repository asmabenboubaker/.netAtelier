using AM.applicationCore.Interfaces;
using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.applicationCore.Services
{
    public class ServicePlan : Service<Plane>, IServicePlane
    {
        public ServicePlan(IUnitOfWork uow) : base(uow) { }

        public bool DeletePlanes()
        {
            DateTime tenYearsAgo = DateTime.Now.AddYears(-10);


            //var planesToDelete =GetAll().Where(p => p.ManufactureDate < tenYearsAgo).ToList();
            //foreach (var plane in planesToDelete)
            //{
            //     Delete(plane);
            //}
            var list = GetAll().Where(p => (DateTime.Now - p.ManufactureDate).TotalDays > 10 * 360);
            foreach (var plane in list)
            {
                Delete(plane);
            }
            Commit();
            return true;
        }

        public IList<Passenger> GetPassengers(Plane p)
        {
            //return p.Flights.SelectMany(f => f.tickets)
            //    .Select(p => p.passenger)
            //    .ToList();
            return GetById(p.PlaneId).Flights.SelectMany(f => f.tickets)
                .Select(p => p.passenger)
                .ToList();
        }

        public bool IsAvailablePlane(Flight f ,int n )
        {
            var capacity = f.Planee.Capacity;
            /// select many nbre des tickes kol 
            var nbre = f.tickets.Count();
            return capacity > nbre;
        }
    }
}
