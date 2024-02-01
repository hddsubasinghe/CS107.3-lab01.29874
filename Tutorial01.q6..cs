using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTORIAL0131Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student grade calculator");
            Console.Write("Enter student's name:");
            string studentName = Console.ReadLine();
            Console.Write("Enter exam marks:");
            int examMarks;
            if (int.TryParse(Console.ReadLine(), out examMarks))
            {
                if (examMarks >= 0 && examMarks <= 100)
                {
                    string grade = DetermineGrade(examMarks);
                    Console.WriteLine($"{studentName}has been assigned grade ${grade}");
                }
                else
                {
                    Console.WriteLine("ERROR:Marks should be between 0 and 100(inclusive).");
                }
            }
            else
            {
                Console.WriteLine("ERROR:Invalid input for exam marks.Please enter a numeric value.");
            }
              
                Console.ReadLine();
            }
            static string DetermineGrade(int marks)
            {
                if (marks >= 75 && marks <= 100)
                    return "A";
                else if (marks >= 60 && marks <= 74)
                    return "B";
                else if (marks >= 50 && marks <= 59)
                    return "C";
                else if (marks >= 40 && marks <= 49)
                    return "D";
                else
                    return "Fail";
            }
        }
    }

