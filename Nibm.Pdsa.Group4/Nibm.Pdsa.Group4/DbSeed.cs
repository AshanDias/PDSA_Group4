using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Nibm.Pdsa.Group4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nibm.Pdsa.Group4
{
    public class DbSeed
    {
        public static void InitializePortle(IServiceScope serviceScope)
        {
            var context = serviceScope.ServiceProvider.GetRequiredService<ApplicationContext>();
            context.Database.Migrate();

            if (!context.Station.Any())
            {
                context.Add(new Station { Id = 1, Name = "Colombo" });
                context.Add(new Station { Id = 2, Name = "Nuwara Eliya" });
                context.Add(new Station { Id = 3, Name = "Galle" });
                context.Add(new Station { Id = 4, Name = "Mirissa" });
                context.SaveChanges();
            }
            if (!context.Distance.Any())
            {
                context.Add(new Distance { Id = 1, fromStationId = 1, toStationId = 2, DistanceKm = 50 });
                context.Add(new Distance { Id = 2, fromStationId = 2, toStationId = 3, DistanceKm = 80 });
                context.Add(new Distance { Id = 3, fromStationId = 3, toStationId = 4, DistanceKm = 60 });
                context.Add(new Distance { Id = 4, fromStationId = 1, toStationId = 4, DistanceKm = 100 });
                context.SaveChanges();
            }

        }
    }
}
