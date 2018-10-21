using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        //Practice project  - do not review
        static void Main(string[] args)
        {
            //Task1_DateTime task1 = new Task1_DateTime();
            //task1.PrintTime();

            //Task2_plusForty task2 = new Task2_plusForty();
            //task2.printDate();

            //Task3_Compare2Dates task3 = new Task3_Compare2Dates();
            //task3.compareDates();

            //Task4_Difference task4 = new Task4_Difference();
            //task4.printDifference();

            Task6_Matrix task6 = new Task6_Matrix();
            task6.fillArray();
            task6.printArray();

            Console.ReadKey();
        }
    }
    
}
