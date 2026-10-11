using System;
namespace Task1
{
    public class Angle
    {
        int gradus;
        int mins;
        int seconds;

        public int Gradus
        {
            get
            {
                return gradus;
            }
            set
            {
                gradus = value;
            }
        }

        public int Mins
        {
            get
            {
                return mins;
            }
            set
            {
                if (value < 0 || value >= 60)
                {
                    mins = 0;
                }
                else
                {
                    mins = value;
                }
            }
        }

        public int Seconds
        {
            get
            {
                return seconds;
            }
            set
            {
                if (value < 0 || value >= 60)
                {
                    seconds = 0;
                }
                else
                {
                    seconds = value;
                }
            }
        }

        public Angle(int gradus, int minutes, int seconds)
        {
            Gradus = gradus;
            Mins = minutes;
            Seconds = seconds;
        }

        public double ToRadians()
        {
            double degrees = gradus + mins / 60.0 + seconds / 3600.0;
            return degrees * Math.PI / 180.0;
        }
    }
}