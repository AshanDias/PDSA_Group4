using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nibm.Pdsa.Group4.Models
{
    public class Distance
    {
        public int Id { get; set; }

        public Station fromStation { get; set; }


        public int fromStationId { get; set; }

        public Station toStation { get; set; }

        public int toStationId { get; set; }

        public int DistanceKm { get; set; }
    }
}
