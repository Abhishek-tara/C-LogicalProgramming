using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class EvenAndOdd
    {
        public static void checkEvenAndOdd() {
            int num = Convert.ToInt32(Console.ReadLine());
            if(num % 2 == 0 )
            {
                Console.WriteLine($"{num} is a Even number");
            }
            else
            {
                Console.WriteLine($"{num} is a Odd number");
            }
        }
    }
}
