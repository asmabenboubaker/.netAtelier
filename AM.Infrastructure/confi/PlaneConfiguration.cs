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
    public class PlaneConfiguration : IEntityTypeConfiguration<Plane>

    {
        public void Configure(EntityTypeBuilder<Plane> builder)
        {   //cle
            builder.HasKey(p => p.PlaneId);
            //table name
            builder.ToTable("myplaness");
            //name prop
            builder.Property(p => p.Capacity).HasColumnName("PlaneCapacity");
        }
    }
}
