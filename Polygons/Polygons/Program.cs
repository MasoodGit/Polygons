﻿using Polygons.Library;
using System;
using System.Collections.Generic;

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


            string[] daysOfWeek =
            {
               "Monday",
               "Tuesday",
               "Wednesday",
               "Thursday",
               "Friday",
               "Saturday",
               "Sunday"
            };

            //DisplayItems(daysOfWeek);

            Console.Read();

        }

        private static void DisplayPolygon(string polygonType, dynamic polygon)
        {

            Console.WriteLine("{0} Number of Sides : {1}", polygonType, polygon.NumberOfSides);
            Console.WriteLine("{0} Perimeter : {1}", polygonType, polygon.GetPerimeter());
            Console.WriteLine("{0} Perimeter : {1}", polygonType, polygon.GetArea());

        }

        public static void DisplayItems<T>(IEnumerable<T> collection)
        {
            using (IEnumerator<T> enumerator = collection.GetEnumerator())
            {
                bool moreItems = enumerator.MoveNext();
                while (moreItems)
                {
                    T item = enumerator.Current;
                    Console.WriteLine(item);
                    moreItems = enumerator.MoveNext();
                }
            }
        }
    }
}
