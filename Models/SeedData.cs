using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Plant
                {	
                	Id = 0
                   	Name = "Basella alba",
                    ImgPath = "https://d2seqvvyy3b8p2.cloudfront.net/018d7852a70888b5e71815b778ac1576.jpg",
                    Family = "Basellaceae",
                    Genus = "Basella",
                    Species = "Basella alba",
                    Origin = "Bangladesh",

                },
                new Plant
                {	
                	Id = 1
                   	Name = "Digitalis purpurea",
                    ImgPath = "https://storage.googleapis.com/powop-assets/kew_profiles/KPPCONT_034322_fullsize.jpg",
                    Family = "Plantaginaceae",
                    Genus = "Digitalis",
                    Species = "Digitalis purpurea",
                    Origin = "Belgium",

                },
                new Plant
                {	
                	Id = 2
                   	Name = "Alismataceae",
                    ImgPath = "https://storage.googleapis.com/powop-assets/kew_profiles/STAG_001842_fullsize.jpg",
                    Family = "Alismataceae",
                    Genus = "",
                    Species = "",
                    Origin = "",

                },
                new Plant
                {	
                	Id = 3
                   	Name = "Adenophora",
                    ImgPath = "https://d2seqvvyy3b8p2.cloudfront.net/b31d5146b57ff2a6d1292f70f4be94ad.jpg",
                    Family = "Campanulaceae",
                    Genus = "Adenophora",
                    Species = "",
                    Origin = "Altay",

                },
            );
            context.SaveChanges();
        }
    }
}
