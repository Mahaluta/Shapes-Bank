using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderSubstringEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "OneTwoThree";
            string result = s.Substring(0, 3);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
