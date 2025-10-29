using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSep25Week4
{
    internal class SensorReading2D : SensorReading
    {
        public Coordinate Coordinate { get; set; }

        public SensorReading2D()
        {
            Console.WriteLine("Blank");
        }

        public SensorReading2D(float val, int time)
        {
            this.Val = val;
            this.Time = time;
        }


    }
}
