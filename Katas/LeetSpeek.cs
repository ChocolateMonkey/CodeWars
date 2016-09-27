using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    
    public static partial class Kata
    {
        private static readonly Dictionary<string, string> Leetify = new Dictionary<string, string>()
            {
                {" ", " "},
                {"A", "@"},
                {"B", "8"},
                {"C", "("},
                {"D", "D"},
                {"E", "3"},
                {"F", "F"},
                {"G", "6"},
                {"H", "#"},
                {"I", "!"},
                {"J", "J"},
                {"K", "K"},
                {"L", "1"},
                {"M", "M"},
                {"N", "N"},
                {"O", "0"},
                {"P", "P"},
                {"Q", "Q"},
                {"R", "R"},
                {"S", "$"},
                {"T", "7"},
                {"U", "U"},
                {"V", "V"},
                {"W", "W"},
                {"X", "X"},
                {"Y", "Y"},
                {"Z", "2"}
            };

        public static string ToLeetSpeak(string str)
        {
            var output = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                output.Append(Leetify[str[i].ToString().ToUpperInvariant()]);
            }
            return output.ToString();
        }
    }
}
