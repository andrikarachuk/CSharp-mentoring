using System;

namespace Tasks
{
    internal struct Rectangle
    {
        private double sideA;
        private double sideB;
        private double area;
        private double perimeter;

        internal Rectangle(double sideA, double sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            area = sideA * sideB;
            perimeter = 2* (sideA + sideB);
        }

        public void Display()
        {
            Console.WriteLine($"Rectangle sides are {sideA} and {sideB} \nIt's Area is {area} \nand Perimeter {perimeter}");
        }
    } 
}
