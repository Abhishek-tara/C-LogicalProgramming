using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class LargestAmongThreeNumbers
    {
        public static void PrintMaxNumber()
        {
            int num1, num2,num3;
            Console.WriteLine("Finding Greatest among three numbers");
            Console.WriteLine("Enter 1st number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 3rd number: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("1st number is greatest among three");
                }
            }
            else if(num2> num3)
            {
                Console.WriteLine("2nd number is greatest among three");
            }
            else
            {
                Console.WriteLine("3rd number is greatest among three");
            }
        }
    }
}
