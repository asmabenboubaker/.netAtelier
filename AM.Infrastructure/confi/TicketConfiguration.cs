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
    public class TicketConfiguration: IEntityTypeConfiguration<Ticket>
    {
         
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            // yaa config lena ya fel context toul 
            builder.HasKey(p => new { p.FlightFK, p.PassengerFK });
            /* config cle etrangere yaa hethi yaa    [ ForeignKey("passenger")] el fe classe ticket  */
            //builder.HasOne(t => t.Passenger).WithMany(p => p.tickets).HasForeignKey(p => p.PassengerFK);
            //builder.HasOne(t => t.Flight).WithMany(p => p.tickets).HasForeignKey(p => p.FlightFK);
        }
    }
}
