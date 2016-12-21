using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons.Library
{
    public class ConcreteRegularPolygon
    {
        public ConcreteRegularPolygon(int sides,int length)
        {
            NumberOfSides = sides;
            SideLength = length;
        }

        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }

        public virtual double GetArea()
        {
            throw new NotImplementedException();
        }
    }

    public class Square : ConcreteRegularPolygon
    {
        public Square(int length) : base(4, length)
        {
        }

        public override double GetArea()
        {
            return SideLength * SideLength;
        }
    }
}
