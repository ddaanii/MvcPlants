using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcPlants.Models;

namespace MvcPlants.Data
{
    public class MvcPlantsContext : DbContext
    {
        public MvcPlantsContext (DbContextOptions<MvcPlantsContext> options)
            : base(options)
        {
        }

        public DbSet<MvcPlants.Models.Plant> Plant { get; set; } = default!;
    }
}
