using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcPlants.Models;

public class PlantFamilyViewModel
{
    public List<Plant>? Plants { get; set; }
    public SelectList? Families { get; set; }
    public string? PlantFamily { get; set; }
    public string? SearchString { get; set; }
}