using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTypeSystemHomework4
{
    class Program
    {
        static void Main(string[] args)
        {

            Tree t1 = new Tree();
            Node root = new Node();
            t1.Insert(root, 10);
            t1.Insert(root, 20);
            t1.Insert(root, 30);
            t1.Traverse(root);

            Console.ReadKey();

        }
    }
}
