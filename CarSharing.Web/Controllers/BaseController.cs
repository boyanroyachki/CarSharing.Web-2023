using CarSharing.Services.Data.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarSharing.Web.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        protected readonly IVehicleService vehicleService;

        public BaseController(IVehicleService vehicleService)
        {
            this.vehicleService = vehicleService;
        }
    }
}
