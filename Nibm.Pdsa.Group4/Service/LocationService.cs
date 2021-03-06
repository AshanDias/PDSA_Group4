﻿using Nibm.Pdsa.Group4.Interface;
using Nibm.Pdsa.Group4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nibm.Pdsa.Group4.Service
{
    public class LocationService : ILocationService
    {
        public LocationService()
        {

        }
        public ApplicationContext _applicationContext;
        public LocationService(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public string findLocationBetweenCities(string f_city, string to_city)
        {
            string result = "0";
            var res = _applicationContext.Distance.Where(x => x.fromStation ==f_city && 
                x.toStation == to_city).FirstOrDefault();
            if (res != null)
            {
                result = res.DistanceKm.ToString();
            }
            return result;
        }

        public string[,] PrintArray()
        {
            try
            {


                List<string> f_cities = new List<string>();
                f_cities = _applicationContext.Distance.Select(x => x.fromStation).Distinct().ToList();


                string[] nameArr = new string[f_cities.Count()];
                nameArr = f_cities.ToArray();
                List<string[]> aa = new List<string[]>();

                string[,] shades = new string[nameArr.Length, nameArr.Length];
               
                for (int i = 0; i < nameArr.Length; i++)
                {
                    for (int y = 0; y < nameArr.Length; y++)
                    {
                        shades[i,y] = findLocationBetweenCities(nameArr[i].ToString(), nameArr[y].ToString());
                       
                    }
                }

                //     return graph;
                return shades;

            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex);
            }
            return null;
        }
    }
}
