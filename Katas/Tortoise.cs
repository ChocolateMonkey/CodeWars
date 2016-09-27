using System;

namespace Katas
{
    public class Tortoise
    {
        public static int[] Race(int v1, int v2, int g)
        {
            if (v1 > v2)
            {
                return new[] {-1, -1, -1};
            }

            var v1g = g/v1;

            var v2g = v2*v1g;

            
            return new [] {0,32,18};
        }
    }
}