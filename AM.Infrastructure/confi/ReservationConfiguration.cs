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
    internal class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            // many to many 
            builder.HasKey(p => new { p.SeatFK, p.PassengerFK , p.DateReservation});

            builder.HasOne(r => r.passenger).WithMany(r => r.reservation).HasForeignKey(r => r.PassengerFK);
            builder.HasOne(r => r.seat).WithMany(r => r.reservation).HasForeignKey(r => r.SeatFK);
        }
    }
}
