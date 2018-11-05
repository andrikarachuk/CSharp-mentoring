using System;

namespace Tasks
{
    static class Task6Matrix
    {
        public static void FillArray()
        {
         Random random = new Random();
         int[,] array = new int[random.Next(1, 10), random.Next(1, 10)];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(1, 10);
                }
            }
        }

        public static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

    // Comments:
    // 1. It's better to make this class static and all its methods static. This class shouldn't have state i.e. fields array and random.
    // 2. Please rename this class to Task6Matrix (camelcase notation) +
    // 3. random field should be moved to FillArray method +
    // 4. All method names should start with a capital letter +
    // 5. You can write rows 20 and 21 in one row i.e. array[i, j] = random.Next(1, 10); +
    // 6. array field should be passed as a parameter to both methods - ??
    // 7. Inside a for loop condition you can also use var - ??conflict with 5th comment??
    // 8. According to the problem definition you have to create "a NxN matrix" i.e. you can't hardcode matrix to [4, 4] dimensions +


}
