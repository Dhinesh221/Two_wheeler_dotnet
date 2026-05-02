using System.ComponentModel.DataAnnotations;

namespace TwowheelerAPI.Models;

public class Vehicle
{
    public int Id { get; set; }

    [Required]
    public string ModelName { get; set; } = string.Empty;

    [Required]
    public string Brand { get; set; } = string.Empty;

    public int EngineCc { get; set; }

    public string MaxPower { get; set; } = string.Empty;

    public string FuelType { get; set; } = string.Empty;

    public string ImageUrl { get; set; } = string.Empty;
}