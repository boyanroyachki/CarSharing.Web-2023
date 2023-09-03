using CarSharing.Data;
using CarSharing.Data.Models;
using CarSharing.Services.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CarSharing.Services.Data
{
    public class ImageService : IIMageService
    {
        private readonly ApplicationDbContext data;
        public ImageService(ApplicationDbContext data) => this.data = data;
        public async Task<Image> GetImageByIdAsync(string imageId)
        {
            var image =  await this.data.Images.FirstOrDefaultAsync(x => x.Id.ToString() == imageId);
            return image;
        }

        public async Task<IEnumerable<Image>> GetVehiclesImagesAsync(string vehicleId)
        {
            var vehicle = await this.data.Vehicles.FirstOrDefaultAsync(x => x.Id.ToString() == vehicleId);
            var images = vehicle.ImageGalery;

            return images;
        }
    }
}
