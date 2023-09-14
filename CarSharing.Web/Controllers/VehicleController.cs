using CarSharing.Services.Data.Interfaces;
using CarSharing.Web.Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static CarSharing.Common.NotificationMessagesConstants;

namespace CarSharing.Web.Controllers
{
    public class VehicleController : BaseController
    {
        public VehicleController(IVehicleService vehicleService, IAgentService agentService) : base(vehicleService, agentService)
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> AllVehicles()
        {
            try
            {
                var model = await this.vehicleService.GetVehiclesAsync();
                return View(model);
            }
            catch (Exception)
            {
                TempData[ErrorMessage] = "Unexpected error accured! Please, try again later.";
                return RedirectToAction("Index");
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> RegisterVehicle()
        {
            string userId = this.User.GetId()!;
            bool userIsAgent = await this.agentService.AgentExistByUserIdAsync(userId);
            if (!userIsAgent)
            {
                this.TempData[ErrorMessage] = "Only AGENTS can register vehicles!";
                return RedirectToAction("Index");  //have to change
            }
            else
            {
                string agentId = await this.agentService.GetAgentIdByUserIdAsync(userId);
                var model = new List<string>();
                model.Add(userId);
                model.Add(agentId);
                return View(model);
            }
        }
    }
}
