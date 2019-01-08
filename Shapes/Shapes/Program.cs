using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();
            Triangle T = new Triangle(6, 3);
            Rectangle R = new Rectangle(4, 2);
            Square S = new Square(4);
            list.Add(T);
            list.Add(R);
            list.Add(S);

            foreach(Shape area in list)
            {
                Console.WriteLine(area.CalculateSurface());
            }

            Console.ReadKey();
        }
    }
}
