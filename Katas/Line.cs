using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Katas
{
    public static class Line
    {
        public static string WhoIsNext(string[] names, long n)
        {
            long p = 1;
            var queued = new List<Person>();

            foreach (var queue in names)
            {
                queued.Add(new Person() {position = p++,Name = queue});
            }

            while (queued.Count < n)
            {
                foreach (var queue in names)
                {
                    queued.Add(new Person() { position = p++, Name = queue });
                    queued.Add(new Person() { position = p++, Name = queue });
                }
            }

            return queued.FirstOrDefault(x => x.position == n).Name;

        }
    }

    public class Person
    {
        public long position { get; set; }
        public string Name { get; set; }
        
    }
}