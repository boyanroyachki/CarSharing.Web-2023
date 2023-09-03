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

        //block 1
        public async Task<bool> VehicleExistByIdAsync(string vehicleId)
        {
            var vehicle = await this.data.Vehicles.FirstOrDefaultAsync(x => x.Id.ToString() == vehicleId);
            return vehicle != null;
        }

        public async Task<IEnumerable<Vehicle>> GetVehiclesByCategoryAsync(int categoryId)
        {
            var vehicles = await this.data.Vehicles.Where(x => x.CategoryId == categoryId).ToListAsync();
            return vehicles;
        }

        public async Task<IEnumerable<Vehicle>> GetVehiclesCheaperThanXAsync(decimal x)
        {
            var vehicles = await this.data.Vehicles.Where(v => v.PricePerHour < x).ToListAsync();
            return vehicles;
        }

        public async Task<IEnumerable<Vehicle>> GetJobsByUserIdAsync(string userId)
        {
            var vehicles = await this.data.Vehicles.Where(x => x.Agent.UserId.ToString() == userId).ToArrayAsync();
            return vehicles;
        }

        public async Task<bool> IsVehicleRentedByIdAsync(string vehicleId)
        {
            var vehicle = await this.data.Vehicles.FirstOrDefaultAsync(x => x.Id.ToString() == vehicleId);
            if (vehicle == null) return false;
            
            return vehicle.IsRented;
        }

        public async Task<bool> IsVehicleOwnedByAgentAsync(string vehicleId, string agentId)
        {
            var vehicle = await this.data.Vehicles.FirstOrDefaultAsync(x => x.Id.ToString() == vehicleId);
            if (vehicle == null) return false;
            
            return vehicle.AgentId.ToString() == agentId;
        }

        public async Task<Vehicle> GetVehicleByIdAsync(string vehicleId)
        {
            var vehicle = await this.data.Vehicles.FirstOrDefaultAsync(x => x.Id.ToString() == vehicleId);
            return vehicle;
        }
        //

        //block 2
        public async Task AddVehicleAsync(AddVehicleViewModel model, string agentId)
        {
            Vehicle vehicle = AutoMapperConfig.MapperInstance.Map<Vehicle>(model);
            vehicle.AgentId = Guid.Parse(agentId);

            await this.data.AddAsync(vehicle);
            await data.SaveChangesAsync();
        }

       




        //
    }
}
