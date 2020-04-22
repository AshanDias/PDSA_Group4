using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nibm.Pdsa.Group4.Models
{
    public class Distance
    {
        public int Id { get; set; }
        
        public string fromStation { get; set; }
        
        public string toStation { get; set; }

        public int DistanceKm { get; set; }
    }
}
