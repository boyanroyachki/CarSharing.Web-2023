using CarSharing.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarSharing.Data.Configurations
{
    public class VehicleEntityConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasOne(v => v.Category)
                .WithMany(c => c.Vehicles)
                .HasForeignKey(v => v.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(v => v.Agent)
                .WithMany(a => a.OwnedVehicles)
                .HasForeignKey(v => v.AgentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(v => v.Ima
        }
    }
}
