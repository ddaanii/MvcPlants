using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcPlants.Data;
using MvcPlants.Models;
using System.Diagnostics;

namespace MvcPlants.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var builder = WebApplication.CreateBuilder();
            builder.Services.AddDbContext<MvcPlantsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MvcPlantsContext") ?? throw new InvalidOperationException("Connection string 'MvcPlantsContext' not found.")));

            var app = builder.Build();
            var scope = app.Services.CreateScope();
            IServiceProvider serviceProvider = scope.ServiceProvider;

            using (var context = new MvcPlantsContext(
            serviceProvider.GetRequiredService<DbContextOptions<MvcPlantsContext>>()))
            {
                PlantFamilyViewModel viewModel = new PlantFamilyViewModel();

                var plants = from m in context.Plant
                             select m;
                viewModel.Plants = plants.ToList();

                return View(viewModel);
            }
            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
