using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nibm.Pdsa.Group4.Interface
{
    public interface IMSTService
    {
        int minKey(int[] key, bool[] mstSet);

        void printMST(int[] parent, int n, int[,] graph);

        void primMST(int[,] graph,int size);
    }
}
