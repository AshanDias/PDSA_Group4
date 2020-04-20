using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nibm.Pdsa.Group4.Interface
{
    interface IShortestPath
    {
         int minDistance(int[] dist, bool[] sptSet);

        string printSolution(int[] dist, int n, String[] branches);

        string dijkstra(int[][] graph, int src);
    }
}
