using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nibm.Pdsa.Group4.Interface
{
     public interface IHashMapDistances
    {
        int minDistance(int[] dist, bool[] sptSet);

        List<KeyValuePair<string, int>> printSolution(int[] dist, int n, string[] branches);

        List<KeyValuePair<string, int>> dijkstra(int[,] graph, int src);
    }
}
