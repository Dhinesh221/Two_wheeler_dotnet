using Microsoft.EntityFrameworkCore;
using TwowheelerAPI.Models;

namespace TwowheelerAPI.Data;

public class VehicleContext : DbContext
{
    public VehicleContext(DbContextOptions<VehicleContext> options) : base(options) { }

    public DbSet<Vehicle> Vehicles { get; set; }
}