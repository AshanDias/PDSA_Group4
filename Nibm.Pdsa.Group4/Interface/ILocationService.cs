using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nibm.Pdsa.Group4.Interface
{
    public interface ILocationService
    {
        string[,] PrintArray();

        string findLocationBetweenCities(string f_city, string to_city);

    }
}
