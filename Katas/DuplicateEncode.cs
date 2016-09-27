using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Katas
{
    public partial class Kata
    {
        public static string DuplicateEncode(string word)
        {
            var lookup = new Dictionary<char,int>();

            var letters = word.ToLowerInvariant();

            foreach (char letter in letters)
            {
                if (!lookup.ContainsKey(letter))
                {
                    lookup.Add(letter, 1);
                }
                else
                {
                    lookup[letter]++;
                }
            }

            var output = new StringBuilder();
            foreach (var letter in letters)
            {
                var count =
                    lookup.SingleOrDefault(x => x.Key == letter).Value;

                output.Append(count == 1 ? "(" : ")");
            }

            return output.ToString();
        }
    }
}