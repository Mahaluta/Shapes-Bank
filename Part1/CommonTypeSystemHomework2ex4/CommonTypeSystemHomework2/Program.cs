using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTypeSystemHomework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Cristiano Ronaldo");
            p1.SetAge(33);

            Person p2 = new Person("Gianluigi Buffon");

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());

            Console.ReadKey();
        }
    }
}
