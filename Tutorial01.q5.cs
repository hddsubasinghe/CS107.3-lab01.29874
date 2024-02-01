using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTORIAL0131Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplication Table Generator");
            Console.Write("Enter a number:");
            int number = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine($"Multiplication table for{number}:");
            for (int i = 1; i <= 10; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number}*{i}={result}");
            }
            Console.ReadLine();
            }

        }
    }

