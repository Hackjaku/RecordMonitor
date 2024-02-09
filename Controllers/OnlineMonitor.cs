using Microsoft.AspNetCore.Mvc;

using Monitor.Globals;
using Monitor.Models;

namespace OnlineMonitor.Controllers;

[ApiController]
[Route("[controller]")]
public class OnlineMonitorController : ControllerBase
{
    private readonly ILogger<OnlineMonitorController> _logger;

    public OnlineMonitorController(ILogger<OnlineMonitorController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "CheckOnline")]
    public ActionResult Get()
    {
        var BasicInfo = new BasicInfo {
            Version = Config.Version,
            ApplicationPort = Config.ApplicationPort,
            ApplicationName = Config.ApplicationName
        };

        return Ok(BasicInfo);
    }
}
