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
                   	Name = "Basella alba",
                    ImgPath = "https://d2seqvvyy3b8p2.cloudfront.net/018d7852a70888b5e71815b778ac1576.jpg",
                    Family = "Basellaceae",
                    Genus = "Basella",
                    Species = "Basella alba",
                    Origin = "Bangladesh",

                },
                new Plant
                {	
                   	Name = "Digitalis purpurea",
                    ImgPath = "https://storage.googleapis.com/powop-assets/kew_profiles/KPPCONT_034322_fullsize.jpg",
                    Family = "Plantaginaceae",
                    Genus = "Digitalis",
                    Species = "Digitalis purpurea",
                    Origin = "Belgium",

                },
                new Plant
                {	
                   	Name = "Alismataceae",
                    ImgPath = "https://storage.googleapis.com/powop-assets/kew_profiles/STAG_001842_fullsize.jpg",
                    Family = "Alismataceae",
                    Genus = "",
                    Species = "",
                    Origin = "",

                },
                new Plant
                {	
                   	Name = "Adenophora",
                    ImgPath = "https://d2seqvvyy3b8p2.cloudfront.net/b31d5146b57ff2a6d1292f70f4be94ad.jpg",
                    Family = "Campanulaceae",
                    Genus = "Adenophora",
                    Species = "",
                    Origin = "Altay",

                },
                new Plant
                {
                    Name = "Amaryllis Belladonna",
                    ImgPath = "https://d2seqvvyy3b8p2.cloudfront.net/e48e1d7de52513832ac891b9d3453e43.jpg",
                    Family = "Amaryllidaceae",
                    Genus = "Amaryllis",
                    Species = "",
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
                    Name = "Hydrangea Macrophylla",
                    ImgPath = "https://d2seqvvyy3b8p2.cloudfront.net/b611b123fbf99bbc43475008c7d09fdb.jpg",
                    Family = "Hydrangeaceae",
                    Genus = "Hydrangea",
                    Species = "Macrophylla",
                    Origin = "Japan",

                }
            );
            context.SaveChanges();
        }
    }
}
