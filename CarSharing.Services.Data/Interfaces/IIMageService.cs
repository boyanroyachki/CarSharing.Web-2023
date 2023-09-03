using CarSharing.Data.Models;

namespace CarSharing.Services.Data.Interfaces
{
    public interface IIMageService
    {
        Task<Image> GetImageByIdAsync(string imageId);
        Task<IEnumerable<Image>> GetVehiclesImagesAsync(string vehicleId);
    }
}
