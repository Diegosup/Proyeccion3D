using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyección_3D
{
    public class Vertex
    {
        public float X;
        public float Y;
        public float Z;
        public float[,] point3D;

        public Vertex(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
            point3D = new float[,] { { x }, { y }, { z } };
        }
    }
}
