using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSep25Week4
{
    public class RGB
    {
        public int Red;
        public int Green;
        public int Blue;

        // Method to set the color
        public void SetColor(int r, int g, int b)
        {
            Red = Math.Clamp(r, 0, 255);
            Green = Math.Clamp(g, 0, 255);
            Blue = Math.Clamp(b, 0, 255);
        }
    }
}
