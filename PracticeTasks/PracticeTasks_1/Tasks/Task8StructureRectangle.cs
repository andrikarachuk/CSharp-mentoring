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

// Comments:
// 1. Resharper hints that sideA and sideB fields can be made readonly.
// 2. Please create area and perimeter as public properties of Rectangle class.
// It's a bad practice to perform something except simple assignments in constructor.
// So, please move area and perimeter calculation to corresponding Area and Perimeter properties.
// 3. I am curious why do you have your constructor internal?:)
// 4. It's better to define one type per file and name the file correpondingly i.e. Rename Task8StructureRectangle to Rectangle

