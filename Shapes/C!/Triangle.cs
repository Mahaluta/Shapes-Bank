using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Triangle : Shape
    {

        // constructor
        public Triangle(int h,int w)
        {
            this.height = h;
            this.width = w;
        }
        
        // methods
        public override int CalculateSurface()
        {
            Console.Write("The area of this triangle is: ");
            return (this.height * this.width) / 2;
        }

    }
}
