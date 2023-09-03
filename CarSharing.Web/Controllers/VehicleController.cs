using CarSharing.Services.Data.Interfaces;
using CarSharing.Web.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace CarSharing.Web.Controllers
{
    public class VehicleController : BaseController
    {
        public VehicleController(IVehicleService vehicleService) : base(vehicleService)
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        //[HttpGet]
        //public async Task<IActionResult> AddVehicle() 
        //{
        //    string? userId = this.User.GetId();

        //}
    }
}
