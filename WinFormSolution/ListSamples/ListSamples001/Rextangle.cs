using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSamples001
{
    class Rectangle
    {
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int GetArea()
        {
            return Width * Height;
        }
    }
}
