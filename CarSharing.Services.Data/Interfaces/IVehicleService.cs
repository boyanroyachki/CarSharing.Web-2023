namespace CarSharing.Services.Data.Interfaces
{
    public interface IVehicleService
    {
        Task<bool> VehicleExistByIdAsync(string vehicleId);
    }
}
