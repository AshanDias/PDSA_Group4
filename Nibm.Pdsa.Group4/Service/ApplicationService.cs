﻿using Microsoft.EntityFrameworkCore;
using Nibm.Pdsa.Group4.Interface;
using Nibm.Pdsa.Group4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nibm.Pdsa.Group4.Service
{
    public class ApplicationService : IApplicationService
    {
        private readonly ApplicationContext _applicationContext;
        public ApplicationService()
        {

        }

        public ApplicationService(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;

        }

      

        public  List<string> GetDistance()
        {
            return _applicationContext.Distance.Select(x => x.fromStation).Distinct().ToList();
        }

        public  int SaveDistance(Distance distance)
        {
            _applicationContext.Distance.Add(distance);
            _applicationContext.SaveChanges();
            return 200;
        }

        public int SaveStation(Station station)
        {
            _applicationContext.Station.Add(station);
            _applicationContext.SaveChanges();
            return 200;
        }

        public int UpdateStation(Station station)
        {
            _applicationContext.Station.Update(station);
            _applicationContext.SaveChanges();
            return 200;
        }

        public int DeleteStation(int id)
        {
            Station station = _applicationContext.Station.Find(id);
            if (station != null)
            {
                _applicationContext.Station.Remove(station);
                _applicationContext.SaveChanges();
                return 200;

            }
            else
            {
                return 500;
            }

        }

        public List<Distance> GetAllDistance()
        {
           return _applicationContext.Distance.ToList();
        }

        public List<Station> GetAllStations()
        {
            return _applicationContext.Station.ToList();
        }

        public int UpdateDistance(Distance distance)
        {
            _applicationContext.Distance.Update(distance);
            _applicationContext.SaveChanges();
            return 200;
        }

        public int DeleteDistance(int id)
        {
            Distance distance = _applicationContext.Distance.Find(id);
            if (distance != null)
            {
                _applicationContext.Distance.Remove(distance);
                _applicationContext.SaveChanges();
                return 200;

            }
            else
            {
                return 500;
            }

        }
    }
}
