using Nibm.Pdsa.Group4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nibm.Pdsa.Group4.Interface
{
   public interface IApplicationService
    {
       List<string> GetDistance();
        //distance
        int SaveDistance(Distance distance);
        int UpdateDistance(Distance distance);
        int DeleteDistance(int id);

        //station
        int SaveStation(Station station);
        int UpdateStation(Station station);
        int DeleteStation(int id);

        List<Distance> GetAllDistance();
        List<Station> GetAllStations();
    }
}
