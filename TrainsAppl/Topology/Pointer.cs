using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainsAppl.Topology
{
    public class Pointer
    {
        public Point[,] sector;
        public Point[,] DoMap(int W, int H)
        {
            sector = new Point[H / 50 + 1, W / 50 + 1];
            Point p;
            int[] y = new int[W / 50];
            int[] x = new int[H / 50];
            for (int j = 0; j < W / 50; j++)
            {
                y[j] = j * 50;
                for (int i = 0; i < H / 50; i++)
                {
                    x[i] = i * 50;
                    p = new Point(y[j], x[i]);
                    sector[i, j] = p;
                }
            }
            return sector;
        }
    }
}

