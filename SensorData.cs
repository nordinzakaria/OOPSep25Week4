using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OOPSep25Week4
{
    internal class SensorData
    {
        /***** attributes/data/properties *****/

        // array of SensorReading objects
        public SensorReading[] temperature = new SensorReading[10];

        /***** methods/operations/behaviors *****/
        public float calcAverage()
        {
            float avg = 0;
            for (int i = 0; i < 10; i++)
            {
                avg += temperature[i].val;
            }
            avg /= 10;

            return avg;
        }

        public float[] getHigherTemperature(float threshold)
        {

            float[] results = new float[10];
            int num = 0;

            for (int i = 0; i < 10; i++)
            {
                if (temperature[i].val > threshold)
                    results[num++] = temperature[i].val;
            }

            return results;
        }

        public void readData()
        {
            Console.WriteLine("Enter 10 temperature data: ");
            for (int i = 0; i < 10; i++)
            {
                string tempstr = Console.ReadLine();
                temperature[i].val = float.Parse(tempstr);

                string timestr = Console.ReadLine();
                temperature[i].time = int.Parse(timestr);
            }
        }

    }
}
