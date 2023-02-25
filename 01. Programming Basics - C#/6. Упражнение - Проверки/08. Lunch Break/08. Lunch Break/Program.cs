using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string seriesName = Console.ReadLine();
            int episodeLength = int.Parse(Console.ReadLine());
            int breakLength = int.Parse(Console.ReadLine());

            double lunchTime = breakLength / 8.0;
            double downTime = breakLength / 4.0;

            double totalTimeLeft = breakLength - (lunchTime + downTime);

            double freeTime = Math.Ceiling(totalTimeLeft - episodeLength);
            double timeNeeded = Math.Ceiling(episodeLength - totalTimeLeft);

            if (totalTimeLeft >= episodeLength)
            {
                Console.WriteLine($"You have enough time to watch {seriesName} and left with {freeTime} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {timeNeeded} more minutes.");
            }

        }
    }
}