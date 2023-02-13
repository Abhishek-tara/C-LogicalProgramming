using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public class QuotientAndRemainder
    {
        public static void FindQuotientAndRemainder()
        {
            int divident = 14;
            int divisor = 5;
            int quotient = divident / divisor;
            int remainder = divident % divisor;

            Console.WriteLine("Divident: {0}, Divisor: {1} : ", divident,divisor);
            Console.WriteLine("Quoitent: " + quotient);
            Console.WriteLine("Remainder: " + remainder);
        }
    }
}
