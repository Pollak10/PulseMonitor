using Microsoft.EntityFrameworkCore;
using PulseMonitor.Api.Models;

namespace PulseMonitor.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
{
}
public DbSet<Job> Jobs { get; set; }
public DbSet<Heartbeat> Heartbeats { get; set; }
}