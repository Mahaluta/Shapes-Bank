using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestStringEx17
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = new string[] { "1", "02", "003", "0004", "00005" };
            List<string> list = new List<String> { "Hello", "HowAreYou", "ICodeInCSharp" };

            string longest = list
                .OrderByDescending(s => s.Length).First();

            Console.WriteLine(longest);
            Console.ReadKey();

        }
    }
}
