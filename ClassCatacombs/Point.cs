using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCatacombs
{
    class Point
    {
        public float X { get; private set; }
        public float Y { get; private set; }

        public Point()
        {
            X = 0;
            Y = 0;
        }

        public Point(float x, float y)
        {
            X = x;
            Y = y;
        }
    }
}
