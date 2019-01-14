using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensionMethodsEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;

            Console.WriteLine(Enumerable.sum(a, b));
            Console.WriteLine(Enumerable.avg(a, b));
            Console.WriteLine(Enumerable.max(a, b));
            // .
            // .
            // .
           Console.ReadKey();
        }
    }
}
