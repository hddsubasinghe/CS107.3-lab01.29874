 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial3101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci Series Printer");
            Console.Write("Enter the value of N:");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n >= 0)
            {
                Console.WriteLine("Fibonacci Series:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"{Fibonacci(i)}");
                }
            }
            else
            {
                Console.WriteLine("ERROR:Please enter a non-negative integer.");
            }
            Console.ReadLine();
        }

        static int Fibonacci(int term)
        {
            if (term <= 1)
                return term;
            else
                return Fibonacci(term - 1) + Fibonacci(term - 2);
        }
    }
}
    
    

        
    

