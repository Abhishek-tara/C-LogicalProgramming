using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class SwapTwoNumbers
    {
        public static void printSwapTwoNumbers() {
            int num1 = 8;
            int num2 = 6;
            Console.WriteLine($"Before swapping num1: {num1}, num2: {num2}");

            num1 = num1 * num2;
            num2 = num1 / num2;
            num1 = num1 / num2;
            Console.WriteLine($"After swapping num1: {num1}, num2: {num2}");


        }
    }
}
