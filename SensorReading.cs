﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSep25Week4
{
    internal class SensorReading
    {
        private float val;
        private int time;

        public SensorReading()
        {
            Console.WriteLine("Blank");
        }

        public SensorReading(float val, int time)
        {
            this.val = val;
            this.time = time;
        }   

        public void SetVal(float v)
        {
            val = v;
        }

        public float GetVal() { return val; }

        // create setter for time
        public void SetTime(int time)
        {
            if (time > 0)
                this.time = time;
            else
                this.time = 0;
        }

        public int GetTime() { return time; }

    }
}







