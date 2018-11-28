using System;

namespace RectangleTask5
{
    class Program
    {
        static void Main()
        {
            //Simple Method
            Task5Rectangle.Area(5, 10);
            Task5Rectangle.Perimeter(5, 10);
            Task5Rectangle.DiagonalLength(5, 10);
            Task5Rectangle.PrintResults();
            Console.WriteLine("***************************************************************************************");

            double sideA = 5, sideB = 10;
            Task5Rectangle.Area(ref sideA, ref sideB);
            Task5Rectangle.Perimeter(ref sideA, ref sideB);
            Task5Rectangle.DiagonalLength(ref sideA, ref sideB);
            Task5Rectangle.PrintResults();
            Console.WriteLine("***************************************************************************************");

            Task5Rectangle.Area(sideA, sideB, out var area);
            Task5Rectangle.Perimeter(sideA, sideB, out var perimeter);
            Task5Rectangle.DiagonalLength(sideA, sideB, out var diagonalLength);
            Console.WriteLine($"Rectangle Area: {area} \nRectangle Perimeter: {perimeter} \nRectangle Diagonal: {diagonalLength}");
            Console.WriteLine("***************************************************************************************");

            double[] sidesDoubles = new double[] {5, 10};
            Task5Rectangle.Area(out area, sidesDoubles);
            Task5Rectangle.Perimeter(out perimeter, sidesDoubles);
            Task5Rectangle.DiagonalLength(out diagonalLength, sidesDoubles);
            Console.WriteLine($"Rectangle Area: {area} \nRectangle Perimeter: {perimeter} \nRectangle Diagonal: {diagonalLength}");

            Console.ReadKey();
        }
    }
}

// Comments:
// 1. Please rename var sidesDoubles to e.g. sides (see comment for details inside Task5Rectangle class), row 29

