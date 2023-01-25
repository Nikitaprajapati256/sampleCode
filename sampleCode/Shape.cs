using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleCode
{
    abstract public class Shape
    {
         public abstract void CalculateArea();
    }
    public class Circle : Shape
    {
        private int radius;
        private double area;
        public Circle(int radius)
        {
            this.radius = radius;
        }

        public override void CalculateArea()
        {
            area = 3.14 * radius * radius;           
        }
        public override string ToString()
        {
            return $"Area of circle is: {area}";
        }
    }
    public class Rectangle : Shape
    {
        private int width;
        private int length;
        private double area;

        public Rectangle(int width, int length)
        {
            this.width = width;
            this.length = length;
            
        }

        public override void CalculateArea()
        {
            area = width * length;
        }
        public override string ToString()
        {
            return $"area of Rectangle is: {area}";
        }
    }
}
