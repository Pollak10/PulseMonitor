namespace PulseMonitor.Api.Models;

public class Job
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string JobKey { get; set; } = string.Empty;
    public int ExpectedIntervalSeconds { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public bool IsActive { get; set; } = true;
}