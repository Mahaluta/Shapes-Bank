using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Square : Shape
    {
        public Square(int wh) // wh --> width = height;
        {
            this.height = wh;
            this.width = wh;
        }

        public override int CalculateSurface()
        {
            Console.Write("The area of this square is: ");
            return this.height * this.width;
        }
    }
}
