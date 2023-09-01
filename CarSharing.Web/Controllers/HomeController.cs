using CarSharing.Services.Data.Interfaces;
using CarSharing.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static CarSharing.Common.NotificationMessagesConstants;

namespace CarSharing.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IVehicleService vehicleService;

        public HomeController(IVehicleService vehicleService)
        {
            this.vehicleService = vehicleService;
        }

        public async Task<IActionResult> Index()
        {
            this.TempData[SuccessMessage] = "Wellcome to the app.";

            if (await vehicleService.VehicleExistByIdAsync("6C0A4AE0-837F-415D-90A1-53FFB2E2142C"))
            {
                this.TempData[WarningMessage] = "All guten joben";
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}