using AM.applicationCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configurations
{
    public class PassangersConfiguration : IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {
            /* builder.Property(p => p.FirstName)
                 .IsRequired()
                 .HasMaxLength(80)
                 .HasDefaultValue("name")
                 .HasColumnType("nchar");*/

            builder.OwnsOne(p => p.fullname, f =>
            {
                f.Property(a => a.FirstName).HasMaxLength(30).HasColumnName("PassFirstName");
                f.Property(a => a.LastName).IsRequired().HasColumnName("PassLastName");
            });
            // tph par defaut .net =>  heritage
            //  
            /*
         

           builder.HasDiscriminator<int>("isTravller").HasValue<Traveller>(2)
                .HasValue<Staff>(0)
                .HasValue<Passenger>(1);*/
        }

    }
}
