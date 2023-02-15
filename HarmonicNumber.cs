using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public class HarmonicNumber
    {
        public static void PrintHarmonic()
        {
            Console.Write("Enter a harmonic number: ");
            int N = Convert.ToInt32(Console.ReadLine());

            if (N != 0)
            {
                for (int i = 1; i <= N; i++)
                {
                    Console.Write("1/" + i + " ");
                }

            }
            else
            {
                Console.WriteLine("Enter a valid number ");
            }
        }
    }
}
