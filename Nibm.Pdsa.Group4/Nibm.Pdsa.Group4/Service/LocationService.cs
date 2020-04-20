using Nibm.Pdsa.Group4.Interface;
using Nibm.Pdsa.Group4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nibm.Pdsa.Group4.Service
{
    public class LocationService : ILocationService
    {
        public ApplicationContext _applicationContext;
        public LocationService(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public string findLocationBetweenCities(string f_city, string to_city)
        {
            return _applicationContext.Distance.Where(x => x.fromStationId ==Convert.ToInt32(f_city) && 
                x.toStationId == Convert.ToInt32(to_city)).FirstOrDefault().DistanceKm.ToString();
        }

        public string[][] PrintArray()
        {
            List<string> f_cities = new List<string>();
            f_cities = _applicationContext.Distance.Select(x => x.fromStation.Name).ToList();


            string[] nameArr = new string[f_cities.Count()];
            nameArr = f_cities.ToArray();
            List<string[]> aa = new List<string[]>();

            string[][] shades = new string[nameArr.Length][];
            for (int i = 0; i < nameArr.Length; i++)
            {
                for (int y = 0; y < nameArr.Length; y++)
                {
                    shades[i][y] = findLocationBetweenCities(nameArr[i], nameArr[y]);
                    //System.out.println(find_location_between_cities(nameArr[i], nameArr[y]));
                }
            }

            //     return graph;
            return shades;
        }
    }
}
