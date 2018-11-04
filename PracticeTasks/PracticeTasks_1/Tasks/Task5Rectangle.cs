using System;

namespace Tasks
{
    public class Task5Rectangle
    {
        private double _sideA;
        private double _sideB;

        public void SetSides(double sideA, double sideB)
        {
            _sideA = sideA;
            _sideB = sideB;
        }

        private double _area;
        private double _perimeter;
        private double _diagonalLength;

        //public Task5Rectangle()
        //{
        //    _sideA = 5;
        //    _sideB = 10;
        //}

        //public Task5Rectangle(double SideA, double SideB)
        //{
        //    this.SideA = SideA;
        //    this.SideB = SideB;
        //}

        //public void CalculateUsual()
        //{
        //    area = SideA * SideB;
        //    perimether = 2 * (SideA + SideB);
        //    diagonalLength = Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2));
        //}

        //public void CalculateRef(double SideA, double SideB, ref double area, ref double perimether, ref double diagonalLength)
        //{
        //    area = SideA * SideB;
        //    perimether = 2 * (SideA + SideB);
        //    diagonalLength = Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2));
        //}

        //public void CalculateOut(double SideA, double SideB, out double area, out double perimether, out double diagonalLength)
        //{
        //    area = SideA * SideB;
        //    perimether = 2 * (SideA + SideB);
        //    diagonalLength = Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2));
        //}

        //public void CalculateParams(out double area, out double perimether, out double diagonalLength, params double[] rectangleParams)
        //{
        //    area = rectangleParams[0] * rectangleParams[1];
        //    perimether = 2 * (rectangleParams[0] + rectangleParams[1]);
        //    diagonalLength = Math.Sqrt(Math.Pow(rectangleParams[0], 2) + Math.Pow(rectangleParams[1], 2));
        //}

        public double Area()
        {
            return _area = _sideA * _sideB;
        }

        public double Area(ref double _sideA, ref double _sideB)
        {
            return _area = _sideA * _sideB;
        }

        public void Area(out double area, params double[] sidesDoubles)
        {
            area = sidesDoubles[0] * sidesDoubles[1];
        }

        public void Perimeter(double sideA, double sideB)
        {
            _perimeter = 2 * (sideA + sideB);
        }

        public double Perimeter(ref double sideA, ref double sideB)
        {
            return _perimeter = 2 * (sideA + sideB);
        }

        public void Perimeter(double sideA, double sideB, out double _perimeter)
        {
            _perimeter = 2 * (sideA + sideB);
        }

        public void Perimeter(out double _perimeter, params double[] sidesDoubles)
        {
            _perimeter = 2 * (sidesDoubles[0] + sidesDoubles[1]);
        }

        public void DiagonalLength(double sideA, double sideB)
        {
            _diagonalLength = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
        }

        public double DiagonalLength(ref double sideA, ref double sideB)
        {
            return _diagonalLength = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
        }

        public void DiagonalLength(double sideA, double sideB, out double _diagonalLength)
        {
           _diagonalLength = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
        }

        public void DiagonalLength(out double _diagonalLength, params double[] sidesDoubles)
        {
            _diagonalLength = Math.Sqrt(Math.Pow(sidesDoubles[0], 2) + Math.Pow(sidesDoubles[1], 2));
        }

        public void PrintResults()
        {
            Console.WriteLine($"Rectangle Area is: {_area} \n" +
                              $"Rectangle Perimether: {_perimeter} \n" +
                              $"Rectangle diagonal length: {_diagonalLength}");
        }
        
    }

    // Comments:
    // 1. You don't follow the problem requirements. You have to have 4 versions of each method e.g. 
    /* int Area(int side1, int side2)
    int Area(ref int side1, ref int side2)
    void Area(int side1, int side2, out int area)
    void Area(params int[] sides, out int area) */
    // This means that you should have a service static class with 12 static methods, without a state.
    // 2. You don't need class fields sideA and sideB. Nevertheless, please remember that class field should always have access modifier private
    // 3. Please rename the class to Task5Rectangle (camelcase notation)
}

