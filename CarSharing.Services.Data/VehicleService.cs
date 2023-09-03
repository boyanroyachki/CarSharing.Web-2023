using CarSharing.Data;
using CarSharing.Data.Models;
using CarSharing.Services.Data.Interfaces;
using CarSharing.Services.Mapping;
using CarSharing.Web.ViewModels.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CarSharing.Services.Data
{
    public class VehicleService : IVehicleService
    {
        private readonly ApplicationDbContext data;
        public VehicleService(ApplicationDbContext data) => this.data = data;

        public async Task AddVehicleAsync(AddVehicleViewModel model, string agentId)
        {
            Vehicle vehicle = AutoMapperConfig.MapperInstance.Map<Vehicle>(model);
            vehicle.AgentId = Guid.Parse(agentId);

            await this.data.AddAsync(vehicle);
            await data.SaveChangesAsync();
        }

        public async Task<bool> VehicleExistByIdAsync(string vehicleId)
        {
            var vehicle = await this.data.Vehicles.FirstOrDefaultAsync(x => x.Id.ToString() == vehicleId);
            if (vehicle == null)
            {
                return false;
            }
            return true;
        }
    }
}
