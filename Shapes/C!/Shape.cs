using System;

namespace Classes
{
    public abstract class Shape
    {
        // fields
        protected int width;
        protected int height;

        // methods
        abstract public int CalculateSurface();       
    }
}
