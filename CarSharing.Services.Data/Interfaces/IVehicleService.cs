using CarSharing.Data.Models;
using CarSharing.Web.ViewModels.ViewModels;

namespace CarSharing.Services.Data.Interfaces
{
    public interface IVehicleService
    {
        //block 1
        Task<Vehicle> GetVehicleByIdAsync(string vehicleId);
        Task<bool> VehicleExistByIdAsync(string vehicleId);
        Task<IEnumerable<Vehicle>> GetVehiclesByCategoryAsync(int categoryId);

        Task<IEnumerable<Vehicle>> GetVehiclesCheaperThanXAsync(decimal x);

        Task<IEnumerable<Vehicle>> GetJobsByUserIdAsync(string userId);

        Task<bool> IsVehicleRentedByIdAsync(string vehicleId);

        Task<bool> IsVehicleOwnedByAgentAsync(string vehicleId, string agentId);

        Task<IEnumerable<Vehicle>> GetVehiclesAsync();
        //

        //block 2
        Task AddVehicleAsync(AddVehicleViewModel model, string agentId);
        //
    }
}
