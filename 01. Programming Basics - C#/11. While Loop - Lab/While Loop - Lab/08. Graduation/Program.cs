using System;
using System.Reflection;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int badMarkCount = 0;
            double totalMarks = 0;
            int grade = 1;

            while (grade <= 12)
            {
                double mark = double.Parse(Console.ReadLine());
                totalMarks += mark;

                

                if (mark < 4)
                {
                    badMarkCount++;

                    if (badMarkCount > 1)
                    {
                        Console.WriteLine($"{name} has been excluded at {grade} grade");
                        return;
                    }
                }
                else
                {
                    grade++;
                }

                

            }
            double averageMark = totalMarks / (12 + badMarkCount);
            Console.WriteLine($"{name} graduated. Average grade: {averageMark:f2}");
            
        }
    }
}
