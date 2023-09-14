using CarSharing.Services.Data.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarSharing.Web.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        protected readonly IVehicleService vehicleService;
        protected readonly IAgentService agentService;

        public BaseController(IVehicleService vehicleService, IAgentService agentService)
        {
            this.vehicleService = vehicleService;
            this.agentService = agentService;
        }
    }
}
