using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Task3_Compare2Dates
    {
        DateTime firstDate = new DateTime(2000, 8, 16, 12, 00, 00);
        DateTime secondDate = new DateTime(2000, 8, 16, 16, 00, 00);

        public void compareDates()
        {
            int result = DateTime.Compare(firstDate, secondDate);

            if (result < 0)
            {
                Console.WriteLine("First date is earlier");
            }
            else if (result > 0)
            {
                Console.WriteLine("Second date is earlier");
            }
            else
            {
                Console.WriteLine("Dates are the same");
            }
        }
        
    }
}
