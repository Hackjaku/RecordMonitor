using Microsoft.AspNetCore.Mvc;

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
        return Ok();
    }
}
