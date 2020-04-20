using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nibm.Pdsa.Group4.Interface
{
    interface IShortestPath
    {
         int minDistance(int[] dist, bool[] sptSet);

        StringBuilder printSolution(int[] dist, int n, string[] branches);

        StringBuilder dijkstra(int[][] graph, int src);
    }
}
