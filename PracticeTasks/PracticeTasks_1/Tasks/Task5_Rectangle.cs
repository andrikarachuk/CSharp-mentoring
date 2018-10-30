using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class Task5_Rectangle
    {
        public double sideA;
        public double sideB;

        public Task5_Rectangle()
        {
            sideA = 5;
            sideB = 10;
        }

        public Task5_Rectangle(double sideA, double sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }

        public double area = 0;
        public double perimether;
        public double diagonalLength;

        public void CalculateUsual()
        {
            area = sideA * sideB;
            perimether = 2 * (sideA + sideB);
            diagonalLength = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
        }

        //public void CalculateRef(double sideA, double sideB, ref double area, ref double perimether, ref double diagonalLength)
        //{
        //    area = sideA * sideB;
        //    perimether = 2 * (sideA + sideB);
        //    diagonalLength = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
        //}

        //public void CalculateOut(double sideA, double sideB, out double area, out double perimether, out double diagonalLength)
        //{
        //    area = sideA * sideB;
        //    perimether = 2 * (sideA + sideB);
        //    diagonalLength = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
        //}

        //public void CalculateParams(out double area, out double perimether, out double diagonalLength, params double[] rectangleParams)
        //{
        //    area = rectangleParams[0] * rectangleParams[1];
        //    perimether = 2 * (rectangleParams[0] + rectangleParams[1]);
        //    diagonalLength = Math.Sqrt(Math.Pow(rectangleParams[0], 2) + Math.Pow(rectangleParams[1], 2));
        //}
        public void PrintResults()
        {
            Console.WriteLine($"Rectangle Area is: {area} \n" +
                              $"Rectangle Perimether: {perimether} \n" +
                              $"Rectangle diagonal length: {diagonalLength}");
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
