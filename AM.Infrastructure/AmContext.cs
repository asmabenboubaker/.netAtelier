using AM.applicationCore;
using AM.Infrastructure.confi;
using AM.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.UI.Console
{
    public class AmContext:DbContext
    {
        public DbSet<Traveller> Travellers { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Passenger> Passengers { get; set; }

        public DbSet<Staff> Staffs { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=(localdb)\mssqllocaldb;" +
                "initial catalog=asmabenboubaker; integrated security=true");
        }
        
        //configuration Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*      // config cle primaire  ya bel les annotaions wala haka
                  modelBuilder.Entity<Flight>().HasKey(f => f.FlightId);
                  //change name of table 
                  modelBuilder.Entity<Flight>().ToTable("voles");
                  //config prop 
                  modelBuilder.Entity<Passenger>().Property(f => f.FirstName).IsRequired()
                      .HasMaxLength(50)
                      .HasDefaultValue("name")
                      .HasColumnType("nchar"); // nchar type sql */
            modelBuilder.ApplyConfiguration(new PassangersConfiguration());
            modelBuilder.ApplyConfiguration(new FlightConfiguration());
            modelBuilder.ApplyConfiguration(new PlaneConfiguration());
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveMaxLength(100).HaveColumnType("varchar");
            configurationBuilder.Properties<DateTime>().HaveColumnType("date");
            configurationBuilder.Properties<double>().HavePrecision(3, 2); //nombre chiffre avant , 3  et apres 2 
        }
    }
}
