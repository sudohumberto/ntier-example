using Microsoft.AspNetCore.Mvc;
using NTierExample.BLL.Services.Abstract;
using NTierExample.Dll.Entities;

namespace NTierExample.Web.Controllers
{
    public class ActivityController : Controller
    {
        private readonly IActivityService _activityService = null!;
        private readonly ILogService _logService = null!;
        private readonly ILogger<HomeController> _logger = null!;

        public ActivityController(IActivityService activityService, ILogService logService, ILogger<HomeController> logger)
        {
            _activityService = activityService;
            _logService = logService;
            _logger = logger;
        }

        public IActionResult Index(ILogService logService)
        {
            List<Activity> activities = _activityService.SelectActivity().Result;
            return View(activities);
        }
    }
}
