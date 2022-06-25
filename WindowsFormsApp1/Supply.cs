using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class DateTime
    {
        public int day;
        public int month;
        public int year;

        public int hour;
        public int min;

        public DateTime(string s)
        {
            var dtStr = s.Split(';');
            day = int.Parse(dtStr[0]);
            month = int.Parse(dtStr[1]);
            year = int.Parse(dtStr[2]);
            hour = int.Parse(dtStr[4]);
            min = int.Parse(dtStr[5]);
        }

    }

    class Supply
    {
        public string fishType;
        public int maxTemperature;
        public int exceedingTime;
        public int minTemperature;
        public int dropTime;
        public DateTime date;
        public int[] temperatureMeasurement;
        public Supply(string fish, int maxT, int excTime, int minT, int drpTime, string dt, string[] tempMeasurement)
        {
            fishType = fish;
            maxTemperature = maxT;
            exceedingTime = excTime;
            minTemperature = minT;
            dropTime = drpTime;
            date = new DateTime(dt);
            temperatureMeasurement = new int[tempMeasurement.Length];

            for (int i = 0; i < tempMeasurement.Length; i++)
            {
                int temp = int.Parse(tempMeasurement[i]);
                if (temp != ' ')
                {
                    temperatureMeasurement[i] = temp;
                }
                i++;
            }
        }
    }
}
