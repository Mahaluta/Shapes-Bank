using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Rectangle : Shape
    {
        // constructor
        public Rectangle(int h,int w)
        {
            this.height = h;
            this.width = w;
        }

        // methods
        public override int CalculateSurface()
        {
            Console.Write("The area of this rectangle is: ");
            return this.height * this.width;
        }
    }
}
