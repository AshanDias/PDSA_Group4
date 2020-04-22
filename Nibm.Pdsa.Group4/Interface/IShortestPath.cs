using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nibm.Pdsa.Group4.Interface
{
    public interface IShortestPath
    {
        Task<int> minDistance(int[] dist, bool[] sptSet);

        Task<StringBuilder> printSolution(int[] dist, int n, string[] branches);

        Task<StringBuilder> dijkstra(int[,] graph, int src);
    }
}
