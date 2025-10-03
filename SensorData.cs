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

        float[] getHigherTemperature(float threshold)
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

        void read()
        {
            cout << "Enter 10 temperature data";
            for (int i = 0; i < 10; i++)
            {
                cin >> temperature[i].val >> temperature[i].time;
            }
        }



    }
}
