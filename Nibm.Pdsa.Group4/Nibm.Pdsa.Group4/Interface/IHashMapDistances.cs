using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nibm.Pdsa.Group4.Interface
{
    interface IHashMapDistances
    {
        int minDistance(int[] dist, bool[] sptSet);

        Dictionary<string, int> printSolution(int[] dist, int n, string[] branches);

        Dictionary<string, int> dijkstra(int[][] graph, int src);
    }
}
