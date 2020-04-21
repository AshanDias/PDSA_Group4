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
                context.Add(new Distance { Id = 1, fromStation = "Colombo", toStation = "Nuwara Eliya", DistanceKm = 50 });
                context.Add(new Distance { Id = 2, fromStation = "Nuwara Eliya", toStation = "Galle", DistanceKm = 80 });
                context.Add(new Distance { Id = 3, fromStation = "Galle", toStation = "Mirissa", DistanceKm = 60 });
                context.Add(new Distance { Id = 4, fromStation = "Colombo", toStation = "Mirissa", DistanceKm = 100 });
                context.SaveChanges();
            }

        }
    }
}
