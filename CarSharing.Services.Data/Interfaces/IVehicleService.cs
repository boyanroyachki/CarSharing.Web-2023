using CarSharing.Web.ViewModels.ViewModels;

namespace CarSharing.Services.Data.Interfaces
{
    public interface IVehicleService
    {
        Task<bool> VehicleExistByIdAsync(string vehicleId);
        Task AddVehicleAsync(AddVehicleViewModel model, string agentId);
    }
}
