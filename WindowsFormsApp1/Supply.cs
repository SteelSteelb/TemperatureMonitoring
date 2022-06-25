using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Date
    {
        private int day;
        private int month;
        private int year;

        private int hour;
        private int sec;
    }

    public class Supply
    {
        private string fishType;
        private int maxTemperature;
        private int exceedingTime;
        private int minTemperature;
        private int dropTime;
        private Date date;
        private int[] temperatureMeasurement = new int[100];
    }
}
