using CarSharing.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;

namespace CarSharing.Data.Configurations
{
    public class VehicleEntityConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            //Fluent API config

            builder.HasOne(v => v.Category)
                .WithMany(c => c.Vehicles)
                .HasForeignKey(v => v.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(v => v.Agent)
                .WithMany(a => a.OwnedVehicles)
                .HasForeignKey(v => v.AgentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(this.GenerateJobs());
        }

        public Vehicle[] GenerateJobs()
        {
            ICollection<Vehicle> vehicles = new HashSet<Vehicle>();
            Vehicle vehicle;
            vehicle = new Vehicle()
            {

                Description = "Very nice, old Ford Ranger! Proven trough the years.",
                Make = "Ford",
                Model = "Ranger",
                ModelYear = "2004",
                PlateNumber = "CB1234MA",
                FuelType = "Disel",
                NoteFromOwner = "Possible to hear strange noises!",
                CategoryId = 1,
                AgentId = Guid.Parse("41D679FE-6B8C-4818-A6DF-F99067DFCBF7")
            };
            vehicles.Add(vehicle);
            vehicle = new Vehicle() 
            {
                Description = "The bigger brother of the F150, the Ford Raptor!",
                Make = "Ford",
                Model = "Ramptor",
                ModelYear = "2019",
                PlateNumber = "CB1238CC",
                FuelType = "Disel",
                NoteFromOwner = "Take care of the paint job!",
                CategoryId = 1,
                AgentId = Guid.Parse("41D679FE-6B8C-4818-A6DF-F99067DFCBF7")
            };
            vehicles.Add(vehicle);

            return vehicles.ToArray(); //seed 1

        }

    }
}
