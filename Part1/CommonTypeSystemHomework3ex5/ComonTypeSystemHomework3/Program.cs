using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComonTypeSystemHomework3
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray64 arr1 = new BitArray64();
            BitArray64 arr2 = new BitArray64();
            BitArray64 arr3 = new BitArray64();

            arr1[0] = 10;
            arr1[1] = 20;
            arr2[0] = 10;
            arr2[1] = 20;

            if(arr1 == arr2)
            {
                Console.WriteLine("arr1 = arr2");
            }
            else
            {
                Console.WriteLine("arr1 != arr2");
            }


            Console.ReadKey();
        }
    }
}
