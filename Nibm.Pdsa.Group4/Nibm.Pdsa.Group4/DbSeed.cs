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
            }

        }
    }
}
