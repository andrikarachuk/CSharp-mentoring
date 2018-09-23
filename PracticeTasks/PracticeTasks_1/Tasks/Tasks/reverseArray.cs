using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Tasks
{
    //Practice class - do not review
    class reverseArray
    {
        static char[] array = new char[3] { 'b', 'a', 't' };
        public reverseArray(char a, char b, char c)
        {
            array[0] = a;
            array[1] = b;
            array[2] = c;

        }
        //char[] array = new char[3] { 'b', 'a', 't' };
        static int arrayLength = array.Length;

        void Reverse ()
        {
            for(int i = arrayLength-1, j = 0; i >= 0; i--, j++)
            {
                char[] arrTemp = new char[arrayLength];
                arrTemp[j] = array[i];
                Console.Write(arrTemp[j]);
            }
        } 

        //    for (int i = arrayLength-1, j = 0; i >= 0; i--, j++)
        //    {

        //        char[] arrTemp = new char[arrayLength];
        //arrTemp[j] = array[i];

        //        Console.Write(arrTemp[j]);
        //    }
    }
}
