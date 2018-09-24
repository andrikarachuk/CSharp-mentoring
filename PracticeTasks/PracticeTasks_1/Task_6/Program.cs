using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, p, c;
            Console.WriteLine("Enter you Marks in three subject to find wheather yor're eleigible for admission");
            Console.Write("Enter Marks in Maths: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Marks in Phy: ");
            p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Marks in Chem: ");
            c = Convert.ToInt32(Console.ReadLine());

            Admission(m, p, c);  // It's good that you started to use separate methods, but try to give them more meaningful names
            
            Console.ReadKey();
        }

        public static void Admission(int a, int b, int c)
        {
            if((a+b+c) >= 180)
            {
                Console.WriteLine("The candidate is eligible for admission");
            }
            else if ((a+b) >= 140 || (a + c) >= 140)
            {
                Console.WriteLine("The candidate is eligible for admission");
            }
            else
            {
                Console.WriteLine("The candidate isn't eligible for admission");
            }
        }
    }

    // What can be improved:
    // 1. You should give meaningful names to your variables, the same for method parameters - "int m, p, c;" OR "Admission(int a, int b, int c)" is a bad practice
    // 2. Admission method can be made private
    // 3. "Magic" numbers 180 and 140 can be made const fields
    // 4. Avoid making grammatical errors in messages that you display to user

}
