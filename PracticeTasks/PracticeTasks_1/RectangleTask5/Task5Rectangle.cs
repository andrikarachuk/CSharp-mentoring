using System;

namespace RectangleTask5
{
    public static class Task5Rectangle
    {
        private static double _area;
        private static double _perimeter;
        private static double _diagonalLength;

        public static double Area(int sideA, int sideB)
        {
            return  _area = sideA * sideB;
        }

        public static double Area(ref double sideA, ref double sideB)
        {
            return _area = sideA * sideB;
        }

        public static void Area(double sideA, double sideB, out double area)
        {
            area = sideA * sideB;
        }

        public static void Area(out double area, params double[] sidesDoubles)
        {
            area = sidesDoubles[0] * sidesDoubles[1];
        }

        public static void Perimeter(double sideA, double sideB)
        {
            _perimeter = 2 * (sideA + sideB);
        }

        public static double Perimeter(ref double sideA, ref double sideB)
        {
            return _perimeter = 2 * (sideA + sideB);
        }

        public static void Perimeter(double sideA, double sideB, out double perimeter)
        {
            perimeter = 2 * (sideA + sideB);
        }

        public static void Perimeter(out double perimeter, params double[] sidesDoubles)
        {
            perimeter = 2 * (sidesDoubles[0] + sidesDoubles[1]);
        }

        public static void DiagonalLength(double sideA, double sideB)
        {
            _diagonalLength = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
        }

        public static double DiagonalLength(ref double sideA, ref double sideB)
        {
            return _diagonalLength = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
        }

        public static void DiagonalLength(double sideA, double sideB, out double diagonalLength)
        {
           diagonalLength = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
        }

        public static void DiagonalLength(out double diagonalLength, params double[] sidesDoubles)
        {
            diagonalLength = Math.Sqrt(Math.Pow(sidesDoubles[0], 2) + Math.Pow(sidesDoubles[1], 2));
        }

        public static void PrintResults()
        {
            Console.WriteLine($"Rectangle Area is: {_area} \n" +
                              $"Rectangle Perimether: {_perimeter} \n" +
                              $"Rectangle diagonal length: {_diagonalLength}");
        }
        
    }

    // Comments:
    // 1. You don't follow the problem requirements. You have to have 4 versions of each method e.g.  +
    /* int Area(int side1, int side2)
    int Area(ref int side1, ref int side2)
    void Area(int side1, int side2, out int area)
    void Area(params int[] sides, out int area) */
    // This means that you should have a service static class with 12 static methods, without a state. +
    // 2. You don't need class fields sideA and sideB. Nevertheless, please remember that class field should always have access modifier private +
    // 3. Please rename the class to Task5Rectangle (camelcase notation) +
}

