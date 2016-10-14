using System;

namespace Katas
{
    public class Tortoise
    {
        public static int[] Race(int v1, int v2, int g)
        {
            if (v1 >= v2)
            {
                return null;
            }

            var vDiff = v2 - v1;

            var timeToMeet = TimeSpan.FromHours((double)g/vDiff);

            return new [] {timeToMeet.Hours,timeToMeet.Minutes,timeToMeet.Seconds};
        }
    }
}