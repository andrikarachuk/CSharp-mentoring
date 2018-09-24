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
        

        Console.WriteLine("Enter you Marks in three subject to find wheather you're eleigible for admission");
            Console.Write("Enter Marks in Maths: ");
            var math = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Marks in Phy: ");
            var phy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Marks in Chem: ");
            var chem = Convert.ToInt32(Console.ReadLine());

            FindIfAbleForAdmission(math, phy, chem);  // It's good that you started to use separate methods, but try to give them more meaningful names
            
            Console.ReadKey();
        }

        private static void FindIfAbleForAdmission(int math, int phy, int chem)
        {
            const int admissionPassOptionPrimary = 180;
            const int admissionPassOptionSecondary = 140;
            const int admissionMarksInMath = 65;
            const int admissionMarksInPhy = 55;
            const int admissionMarksInChem = 50;

            if ((math+phy+chem) >= admissionPassOptionPrimary)
            {
                Console.WriteLine("The candidate is eligible for admission");
            }
            else if (math >= admissionMarksInMath & phy >= admissionMarksInPhy &chem >= admissionMarksInChem)
            {
                Console.WriteLine("The candidate is eligible for admission");
            }
            else if ((math+phy) >= admissionPassOptionSecondary || (math + chem) >= admissionPassOptionSecondary)
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
    // 1. You should give meaningful names to your variables, the same for method parameters - "int m, p, c;" OR "Admission(int a, int b, int c)" is a bad practice -> Checked
    // 2. Admission method can be made private -> Checked
    // 3. "Magic" numbers 180 and 140 can be made const fields -> Checked
    // 4. Avoid making grammatical errors in messages that you display to user -> Checked

}
