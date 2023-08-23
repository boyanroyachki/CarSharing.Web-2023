using CarSharing.Data;
using CarSharing.Services.Data.Interfaces;

namespace CarSharing.Services.Data
{
    public class ApplicationService : IApplicationService
    {
        private readonly ApplicationDbContext data;
        public ApplicationService(ApplicationDbContext data)
        {
            this.data = data;
        }

        //code...
    }
}
