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
                // context.Add(new Station { Id = 1, Name = "Colombo" });
                // context.Add(new Station { Id = 2, Name = "Nuwara Eliya" });
                // context.Add(new Station { Id = 3, Name = "Galle" });
                // context.Add(new Station { Id = 4, Name = "Mirissa" });

                context.Add(new Station { Name = "545tjgjgk.gff"});
                context.Add(new Station { Name = "ANURADHAPURA"});
                context.Add(new Station { Name = "POLGAHAWELA"});
                context.Add(new Station { Name = "GAMPAHA"});
                context.Add(new Station { Name = "RAGAMA"});
                context.Add(new Station { Name = "GALGAMUWA"});
                context.Add(new Station { Name = "COLOMBO"});
                context.Add(new Station { Name = "KELANIYA"});
                context.Add(new Station { Name = "GALLE"});
                context.Add(new Station { Name = "MATARA"});
                context.Add(new Station { Name = "DAMBULLA"});
                context.Add(new Station { Name = "JAFFNA"});
                context.Add(new Station { Name = "333333"}); 
                context.SaveChanges();
            }
            if (!context.Distance.Any())
            {
                // context.Add(new Distance { Id = 1, fromStation = "Colombo", toStation = "Nuwara Eliya", DistanceKm = 50 });
                // context.Add(new Distance { Id = 2, fromStation = "Nuwara Eliya", toStation = "Galle", DistanceKm = 80 });
                // context.Add(new Distance { Id = 3, fromStation = "Galle", toStation = "Mirissa", DistanceKm = 60 });
                // context.Add(new Distance { Id = 4, fromStation = "Colombo", toStation = "Mirissa", DistanceKm = 100 });

                 context.Add(new Distance {fromStation ="KURUNEGALA", toStation ="KURUNEGALA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="KURUNEGALA", toStation ="ANURADHAPURA",DistanceKm = 90});
                 context.Add(new Distance {fromStation ="KURUNEGALA", toStation ="GALGAMUWA",DistanceKm = 65});
                 context.Add(new Distance {fromStation ="KURUNEGALA", toStation ="GAMPAHA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="KURUNEGALA", toStation ="RAGAMA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="KURUNEGALA", toStation ="KELANIYA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="KURUNEGALA", toStation ="COLOMBO",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="KURUNEGALA", toStation ="GALLE",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="KURUNEGALA", toStation ="MATARA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="ANURADHAPURA", toStation ="KURUNEGALA",DistanceKm = 90});
                 context.Add(new Distance {fromStation ="ANURADHAPURA", toStation ="ANURADHAPURA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="ANURADHAPURA", toStation ="GALGAMUWA",DistanceKm = 60});
                 context.Add(new Distance {fromStation ="ANURADHAPURA", toStation ="POLGAHAWELA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="ANURADHAPURA", toStation ="GAMPAHA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="ANURADHAPURA", toStation ="RAGAMA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="ANURADHAPURA", toStation ="KELANIYA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="ANURADHAPURA", toStation ="COLOMBO",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="ANURADHAPURA", toStation ="GALLE",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="ANURADHAPURA", toStation ="MATARA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="KURUNEGALA", toStation ="POLGAHAWELA", DistanceKm =33});
                 context.Add(new Distance {fromStation ="GALGAMUWA", toStation ="KURUNEGALA",DistanceKm = 65});
                 context.Add(new Distance {fromStation ="GALGAMUWA", toStation ="ANURADHAPURA", DistanceKm =60});
                 context.Add(new Distance {fromStation ="GALGAMUWA", toStation ="GALGAMUWA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="GALGAMUWA", toStation ="POLGAHAWELA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="GALGAMUWA", toStation ="GAMPAHA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="GALGAMUWA", toStation ="RAGAMA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="GALGAMUWA", toStation ="KELANIYA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="GALGAMUWA", toStation ="COLOMBO",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="GALGAMUWA", toStation ="GALLE",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="GALGAMUWA", toStation ="MATARA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="POLGAHAWELA",toStation ="MATARA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="POLGAHAWELA",toStation ="GALLE",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="POLGAHAWELA",toStation ="KELANIYA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="POLGAHAWELA",toStation ="RAGAMA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="POLGAHAWELA",toStation ="GAMPAHA",DistanceKm = 75});
                 context.Add(new Distance {fromStation ="POLGAHAWELA",toStation ="POLGAHAWELA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="POLGAHAWELA",toStation ="GALGAMUWA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="POLGAHAWELA",toStation ="ANURADHAPURA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="POLGAHAWELA",toStation ="KURUNEGALA",DistanceKm = 33});
                 context.Add(new Distance {fromStation ="RAGAMA",toStation ="KURUNEGALA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="RAGAMA",toStation ="ANURADHAPURA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="RAGAMA",toStation ="GALGAMUWA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="RAGAMA",toStation ="POLGAHAWELA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="RAGAMA",toStation ="GAMPAHA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="RAGAMA",toStation ="RAGAMA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="RAGAMA",toStation ="KELANIYA",DistanceKm = 12});
                 context.Add(new Distance {fromStation ="RAGAMA",toStation ="COLOMBO",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="RAGAMA",toStation ="GALLE",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="RAGAMA",toStation ="MATARA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="KELANIYA",toStation ="KURUNEGALA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="KELANIYA",toStation ="ANURADHAPURA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="KELANIYA",toStation ="GALGAMUWA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="KELANIYA",toStation ="POLGAHAWELA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="KELANIYA",toStation ="GAMPAHA",DistanceKm = 30});
                 context.Add(new Distance {fromStation ="KELANIYA",toStation ="RAGAMA",DistanceKm = 12});
                 context.Add(new Distance {fromStation ="KELANIYA",toStation ="KELANIYA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="KELANIYA",toStation ="COLOMBO",DistanceKm = 35});
                 context.Add(new Distance {fromStation ="KELANIYA",toStation ="GALLE",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="KELANIYA",toStation ="MATARA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="COLOMBO",toStation ="KURUNEGALA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="COLOMBO",toStation ="ANURADHAPURA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="COLOMBO",toStation ="GALGAMUWA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="COLOMBO",toStation ="POLGAHAWELA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="COLOMBO",toStation ="GAMPAHA",DistanceKm = 45});
                 context.Add(new Distance {fromStation ="COLOMBO",toStation ="RAGAMA", DistanceKm =0});
                 context.Add(new Distance {fromStation ="COLOMBO",toStation ="KELANIYA", DistanceKm =35});
                 context.Add(new Distance {fromStation ="COLOMBO",toStation ="COLOMBO",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="COLOMBO",toStation ="GALLE",DistanceKm = 150});
                 context.Add(new Distance {fromStation ="COLOMBO",toStation ="MATARA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="GALLE",toStation ="KURUNEGALA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="GALLE",toStation ="ANURADHAPURA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="GALLE",toStation ="GALGAMUWA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="GALLE",toStation ="POLGAHAWELA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="GALLE",toStation ="GAMPAHA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="GALLE",toStation ="RAGAMA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="GALLE",toStation ="KELANIYA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="GALLE",toStation ="COLOMBO",DistanceKm = 150});
                 context.Add(new Distance {fromStation ="GALLE",toStation ="MATARA",DistanceKm = 30});
                 context.Add(new Distance {fromStation ="MATARA",toStation ="KURUNEGALA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="MATARA",toStation ="ANURADHAPURA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="MATARA",toStation ="GALGAMUWA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="MATARA",toStation ="POLGAHAWELA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="MATARA",toStation ="GAMPAHA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="MATARA",toStation ="RAGAMA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="MATARA",toStation ="KELANIYA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="MATARA",toStation ="COLOMBO",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="MATARA",toStation ="GALLE",DistanceKm = 30});
                 context.Add(new Distance {fromStation ="MATARA",toStation ="MATARA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="GALLE",toStation ="GALLE",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="POLGAHAWELA",toStation ="COLOMBO",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="GAMPAHA",toStation ="KURUNEGALA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="GAMPAHA",toStation ="ANURADHAPURA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="GAMPAHA",toStation ="GALGAMUWA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="GAMPAHA",toStation ="POLGAHAWELA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="GAMPAHA",toStation ="GAMPAHA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="GAMPAHA",toStation ="RAGAMA", DistanceKm =12});
                 context.Add(new Distance {fromStation ="GAMPAHA",toStation ="COLOMBO",DistanceKm = 45});
                 context.Add(new Distance {fromStation ="GAMPAHA",toStation ="GALLE",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="GAMPAHA",toStation ="MATARA",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="GALLE",toStation ="GALLE",DistanceKm = 0});
                 context.Add(new Distance {fromStation ="JAFFNA",toStation = "ANURADHAPURA",DistanceKm = 78});
                 context.Add(new Distance {fromStation ="JAFFNA", toStation ="DAMBULLA",DistanceKm = 89});
                 context.Add(new Distance {fromStation ="545tjgjgk.gff",toStation = "ANURADHAPURA",DistanceKm = 56});
                 context.SaveChanges();
            }

        }
    }
}
