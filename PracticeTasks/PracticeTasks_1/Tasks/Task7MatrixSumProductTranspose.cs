using System;

namespace Tasks
{
    static class Task7MatrixSumProductTranspose
    {
        static Random random = new Random();

        public static int[,] FillArray(int n1, int n2)
        {
            var array = new int[n1, n2];

            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(1, 10);
                }
            }

            return array;
        }

        public static int[,] SumArrays(int[,] array1, int[,] array2)
        {
            var arraySum = new int[array1.GetLength(0), array2.GetLength(1)];

            for (var i = 0; i < array1.GetLength(0); i++)
            {
                for (var j = 0; j < array1.GetLength(1); j++)
                {
                    arraySum[i, j] = array1[i, j] + array2[i, j];
                }
            }

            return arraySum;
        }

        public static int[,] ProductArrays(int[,] array1, int[,] array2)
        {
            var arrayProduct = new int[array1.GetLength(0), array2.GetLength(1)];

            for (var i = 0; i < array1.GetLength(0); i++)
            {
                for (var j = 0; j < array2.GetLength(1); j++)
                {
                    for (var k = 0; k < array2.GetLength(0); k++)
                    {
                        arrayProduct[i, j] += array1[i,k] * array2[k,j];
                    }
                }
            }

            return arrayProduct;
        }

        public static int[,] TransposeArray(int[,] array)
        {
            var arrayTranspose = new int[array.GetLength(0),array.GetLength(1)];
            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var j = 0; j < array.GetLength(1); j++)
                {
                    arrayTranspose[j, i] = array[i, j];
                }
            }
            return arrayTranspose;
        }
        public static void PrintArray(int[,] array)
        {
            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

// Comments:
// 1. You could have reused FillArray and PrintArray methods from another static class. You are violating DRY principle :) - Don't repeat yourself
// 2. There is a bug in TransposeArray method, currently this method will only be able to transpose a matrix with equal dimensions
