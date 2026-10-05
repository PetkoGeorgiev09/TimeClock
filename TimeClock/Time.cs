using System;
using System.Collections.Generic;
using System.Text;

namespace TimeClock
{
    internal class Time
    {
        private int hours;
        private int minutes;
        private int seconds;

        public int Hours
        {
            get { return hours; }
            set
            {
                if (value >= 0)
                    hours = value;
                else
                    Console.WriteLine("Часовете не могат да приемат отрицателни стойности!");
            }
        }
        public int Minutes
        {
            get { return minutes; }
            set
            {
                if (value >= 0)
                    minutes = value;
                else
                    Console.WriteLine("Минутите не могат да приемат отрицателни стойности!");
            }
        }
        public int Seconds
        {
            get { return seconds; }
            set
            {
                if (value >= 0)
                    seconds = value;
                else
                    Console.WriteLine("Секундите не могат да приемат отрицателни стойности!");
            }
        }

        public Time()
        {
            Hours = 00;
            Minutes = 00;
            Seconds = 00;
        }

        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public void ShowTime()
        {
            Console.WriteLine($"{Hours}:{Minutes}:{Seconds}");
        }
    }
}
