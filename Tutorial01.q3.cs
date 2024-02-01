using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTORIAL0131Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum Calculator");

            
            Console.Write("Enter a positive integer: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput > 0)
            {
              
                int sum = CalculateSum(userInput);
                Console.WriteLine($"The sum of numbers from 1 to {userInput} is: {sum}");
            }
            else
            {
                Console.WriteLine("ERROR: Please enter a positive integer.");
            }

            Console.ReadLine();
        }

        
        static int CalculateSum(int n)
        {
            return (n * (n + 1)) / 2;

        }
    }
}
