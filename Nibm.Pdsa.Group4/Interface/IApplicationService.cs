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

        int SaveDistance(Distance distance);

        int SaveStation(Station station);
        int UpdateStation(Station station);
        int DeleteStation(int id);
        List<Distance> GetAllDistance();
        List<Station> GetAllStations();
    }
}
