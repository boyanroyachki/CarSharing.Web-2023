using CarSharing.Services.Data.Interfaces;
using CarSharing.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static CarSharing.Common.NotificationMessagesConstants;

namespace CarSharing.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IApplicationService applicationService;

        public HomeController(IApplicationService applicationService)
        {
            this.applicationService = applicationService;
        }

        public IActionResult Index()
        {
            this.TempData[SuccessMessage] = "Wellcome to the app.";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}