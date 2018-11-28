using System;

namespace Tasks
{
    internal class Program
    {
        static void Main()
        {
            //Task1DateTime.PrintTime();

            //Task2PlusForty.PrintDate();

            //Task3Compare2Dates.CompareDates(new DateTime(2000, 8, 16, 12, 00, 00), new DateTime(2000, 8, 16, 16, 00, 00));

            //Task4Difference.Difference(new DateTime(2000, 1, 1, 00, 00, 00));

            //var task5 = new Task5Rectangle();
            ////task5.calculateusual(); // <- start here to use usual usual method 
            ////task5.calculateref(task5.sidea, task5.sideb, ref task5.area, ref task5.perimether, ref task5.diagonallength);
            ////task5.calculateout(task5.sidea, task5.sideb, out task5.area, out task5.perimether, out task5.diagonallength);
            ////task5.calculateparams(out task5.area, out task5.perimether, out task5.diagonallength, task5.sidea, task5.sideb);

            //var array = Task6Matrix.FillArray(3,3);
            //Task6Matrix.PrintArray(array);

            //var array1 = Task7MatrixSumProductTranspose.FillArray(3, 2);
            //Task7MatrixSumProductTranspose.PrintArray(array1);

            //var array2 = Task7MatrixSumProductTranspose.FillArray(3, 3);
            //Task7MatrixSumProductTranspose.PrintArray(array2);

            //var arraySum = Task7MatrixSumProductTranspose.SumArrays(array1, array2);
            //Task7MatrixSumProductTranspose.PrintArray(arraySum);
            //Console.WriteLine();

            //var arrayProduct = Task7MatrixSumProductTranspose.ProductArrays(array1, array2);
            //Task7MatrixSumProductTranspose.PrintArray(arrayProduct);
            //Console.WriteLine();

            //var arrayTranspose = Task7MatrixSumProductTranspose.TransposeArray(array1);
            //Task7MatrixSumProductTranspose.PrintArray(arrayTranspose);

            Rectangle rectangle = new Rectangle(5, 10);
            rectangle.Display();

            Console.ReadKey();
        }
    }

    // Comments:
    // 1. You can use var - rows 13, 16, 19, 22 etc. - var task1 = new Task1_DateTime(); +

}
