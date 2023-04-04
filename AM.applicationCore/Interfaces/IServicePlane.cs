using AM.ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.applicationCore.Interfaces
{
    public interface IServicePlane :IService<Plane>
    {
        public IList<Passenger> GetPassengers(Plane p);
        public bool IsAvailablePlane(Flight p,int n);

        public bool DeletePlanes();
    }
}
