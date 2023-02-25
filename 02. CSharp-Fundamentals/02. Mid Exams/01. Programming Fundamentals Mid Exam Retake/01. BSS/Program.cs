using System;

namespace _01._BSS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentCount = int.Parse(Console.ReadLine());

            int numberOfLectures = int.Parse(Console.ReadLine());

            int addBonus = int.Parse(Console.ReadLine());

            double totalBonus = 0;
            double maxBonus = double.MinValue;
            int attendances = 0;

            if (studentCount == 0 || numberOfLectures == 0)
            {
                Console.WriteLine($"Max Bonus: 0.");
                Console.WriteLine($"The student has attended 0 lectures.");
                return;
            }

            for (int i = 0; i < studentCount; i++)
            {
                int attendanceOfStudent = int.Parse(Console.ReadLine());

                totalBonus = 1.0 * attendanceOfStudent / numberOfLectures * (5 + addBonus);

                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    attendances = attendanceOfStudent;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {attendances} lectures.");
        }
    }
}
