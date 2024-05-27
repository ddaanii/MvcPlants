using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcPlants.Data;
using System;
using System.Linq;

namespace MvcPlants.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcPlantsContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcPlantsContext>>()))
        {
            // Look for any Plants.
            if (context.Plant.Any())
            {
                return;   // DB has been seeded
            }
            context.Plant.AddRange(
                new Plant
                {
                    Name = "Amaryllis",
                    ImgPath = "https://d2seqvvyy3b8p2.cloudfront.net/e48e1d7de52513832ac891b9d3453e43.jpg",
                    Family = "Amaryllidaceae",
                    Genus = "Amaryllis",
                    Species = "Amaryllis Belladonna",
                    Origin = "Cape Provinces",

                },
                new Plant
                {
                    Name = "Zinnia Acerosa",
                    ImgPath = "https://d2seqvvyy3b8p2.cloudfront.net/a59ebb4e575f88fa8722e2f606ba776a.jpg",
                    Family = "Asteraceae",
                    Genus = "Zinnia",
                    Species = "Acerosa",
                    Origin = "Mexico",

                },
                new Plant
                {
                    Name = "Hydrangea",
                    ImgPath = "https://d2seqvvyy3b8p2.cloudfront.net/b611b123fbf99bbc43475008c7d09fdb.jpg",
                    Family = "Hydrangeaceae",
                    Genus = "Hydrangea",
                    Species = "Hydrangea Macrophylla",
                    Origin = "Japan",

                },
                new Plant
                {
                    Name = "Poppy",
                    ImgPath = "https://rachelchoflowers.com/wp-content/uploads/2019/09/Learn-About-Augusts-Birth-Flower-1-scaled.jpeg",
                    Family = "Papaveraceae",
                    Genus = "Papaver",
                    Species = "Papaver Rhoeas",
                    Origin = "Europe",

                },
                new Plant
                {
                    Name = "Foxglove",
                    ImgPath = "https://storage.googleapis.com/powop-assets/kew_profiles/KPPCONT_034322_fullsize.jpg",
                    Family = "Plantaginaceae",
                    Genus = "Digitalis",
                    Species = "Digitalis Purpurea",
                    Origin = "Belgium",

                },
                new Plant
                {
                    Name = "Dahlia",
                    ImgPath = "https://images.pexels.com/photos/326014/pexels-photo-326014.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                    Family = "Asteraceae",
                    Genus = "Dahlia",
                    Species = "Ball Dahlia",
                    Origin = "Mexico",

                },
                new Plant
                {
                    Name = "Lavender",
                    ImgPath = "https://images.pexels.com/photos/414949/pexels-photo-414949.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                    Family = "Lamiaceae",
                    Genus = "Lavandula",
                    Species = "",
                    Origin = "Europe",
                },
                new Plant
                {
                    Name = "Fire Lily",
                    ImgPath = "https://images.pexels.com/photos/17454553/pexels-photo-17454553/free-photo-of-fire-lily-flower.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                    Family = "Amaryllidaceae",
                    Genus = "Cyrtanthus",
                    Species = "Cyrtanthus Ventricosus",
                    Origin = "South Africa",
                }
            );
            context.SaveChanges();
        }
    }
}
