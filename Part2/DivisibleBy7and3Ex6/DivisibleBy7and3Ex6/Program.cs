using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleBy7and3Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 3, 7, 20, 21, 27 ,42 };

            var list1 = list
                .Where(num => num % 3 == 0)
                .Where(num => num % 7 == 0)
                .Select(num => num);

            var list2 =
                from num in list
                where num % 3 == 0
                where num % 7 == 0
                select num;

            foreach(int num in list1)
            {
                Console.Write($"{num} ");
            }

            Console.WriteLine();

            foreach (int num in list2)
            {
                Console.Write($"{num} ");
            }

            Console.ReadKey();
        }
    }
}
