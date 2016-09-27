using System;

namespace Katas
{
    public partial class Kata
    {
        public static bool IsSquare(int n)
        {
            var check = Math.Sqrt(n);

            return n%check == 0;
        }
    }
}