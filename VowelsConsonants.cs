using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public class VowelsConsonants
    {          
       public static void checkVowels()
        {
            char ch = Convert.ToChar(Console.ReadLine());
            if(ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u') {
                Console.WriteLine($"{ch} is a vowel");
            }
            else if(ch >= 'a' && ch <= 'z')
            {
                Console.WriteLine($"{ch} is a consonant");
            }
        }
    }
}
