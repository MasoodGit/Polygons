using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polygons.Library;

namespace Polygons
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(5);
            DisplayPolygon("Square", square);

            var triangle = new Triangle(4);
            DisplayPolygon("Triangle", triangle);


            var octagon = new Octagon(7);
            DisplayPolygon("Octagon", octagon);

            Console.Read();

        }

        private static void DisplayPolygon(string polygonType, dynamic polygon)
        {

            Console.WriteLine("{0} Number of Sides : {1}",polygonType,polygon.NumberOfSides);
        }
    }
}
