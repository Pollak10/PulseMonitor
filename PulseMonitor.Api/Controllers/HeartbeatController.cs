using Microsoft.AspNetCore.Mvc;

namespace PulseMonitor.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HeartbeatController : ControllerBase
{
    [HttpPost("{jobId}")]
    public IActionResult ReceiveHeartbeat(string jobId)
    {
        var timestamp = DateTime.UtcNow;
        
        Console.WriteLine($"Heartbeat received for job: {jobId} at {timestamp}");
        
        return Ok(new
        {
            jobId = jobId,
            receivedAt = timestamp,
            status = "received"
        });
    }
}