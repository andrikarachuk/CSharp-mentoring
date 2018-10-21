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
            char[] array = new char[3] { 'b', 'a', 't' };

            int arrayLength = array.Length;

            for (int i = arrayLength-1, j = 0; i >= 0; i--, j++)
            {
                
                char[] arrTemp = new char[arrayLength];
                arrTemp[j] = array[i];
                
                Console.Write(arrTemp[j]);
            }

            Console.ReadKey();
        }
    }
    
}
