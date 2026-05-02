using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TwowheelerAPI.Data;
using TwowheelerAPI.Models;

namespace TwowheelerAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VehiclesController : ControllerBase
{
    private readonly VehicleContext _context;

    public VehiclesController(VehicleContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Vehicle>>> GetVehicles()
    {
        return await _context.Vehicles.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Vehicle>> PostVehicle(Vehicle vehicle)
    {
        _context.Vehicles.Add(vehicle);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetVehicles), new { id = vehicle.Id }, vehicle);
    }
}