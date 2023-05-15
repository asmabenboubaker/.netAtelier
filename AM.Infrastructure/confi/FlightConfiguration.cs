using AM.applicationCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.confi
{
    public  class FlightConfiguration:IEntityTypeConfiguration<Flight>
    {


        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.HasKey(f => f.FlightId);
            builder.ToTable("vols ");
            // relation one to many 
            builder.HasOne(f => f.Planee).WithMany(p => p.Flights)

                .HasForeignKey(f => f.PlaneId)
            .OnDelete(DeleteBehavior.SetNull);
            //ralation many to many 
            /*builder.HasMany(f => f.Passengers)
                .WithMany(p => p.flights)
                .UsingEntity(pf => pf.ToTable("myreservations"));*/
        }
    }

}
