using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTORIAL0131Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rectangle Area Calculator");

            
            Console.Write("Enter the length of the rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the width of the rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());

            
            double area = CalculateRectangleArea(length, width);
            Console.WriteLine($"The area of the rectangle is: {area}");

            Console.ReadLine(); 
        }

        
        static double CalculateRectangleArea(double length, double width)
        {
            return length * width;

        }
    }
}
