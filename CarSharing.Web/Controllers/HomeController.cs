using CarSharing.Services.Data.Interfaces;
using CarSharing.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static CarSharing.Common.NotificationMessagesConstants;
using static ToolsLibrary.Locations;

namespace CarSharing.Web.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(IVehicleService vehicleService, IAgentService agentService) : base(vehicleService, agentService) { }
        
        public async Task<IActionResult> Index()
        {
            this.TempData[SuccessMessage] = GetRandomCoordinates();

            if (await vehicleService.VehicleExistByIdAsync("6C0A4AE0-837F-415D-90A1-53FFB2E2142C"))
            {
                this.TempData[WarningMessage] = GetRandomCoordinates();
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