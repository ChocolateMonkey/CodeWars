using System;
using System.Linq;
using System.Text;

namespace Katas
{
    public static partial class Kata
    {
        public static string Disemvowel(string str)
        {
            var check = new [] {"a", "e", "i", "o", "u"};

            var output = new StringBuilder();
                                   
            for (int i = 0; i < str.Length; i++)
            {
                if (!check.Contains(str[i].ToString().ToLowerInvariant()))
                {
                    output.Append(str[i]);
                }
            }

            return output.ToString();
        }
    }
}