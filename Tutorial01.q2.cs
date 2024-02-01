using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTORIAL0131Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even or Odd Checker");

            for (int i = 1; i <= 10; i++)
            {
               
                Console.Write($"Enter number {i}: ");
                int number = Convert.ToInt32(Console.ReadLine());

                
                string result = IsEven(number) ? "even" : "odd";
                Console.WriteLine($"Number {number} is {result}");
            }

            Console.ReadLine(); 
        }

        
        static bool IsEven(int number)
        {
            return number % 2 == 0;

        }
    }
}
