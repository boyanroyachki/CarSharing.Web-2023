using CarSharing.Data;
using CarSharing.Services.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CarSharing.Services.Data
{
    public class VehicleService : IVehicleService
    {
        private readonly ApplicationDbContext data;
        public VehicleService(ApplicationDbContext data) => this.data = data;

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
