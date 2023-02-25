using System;
using System.Collections.Generic;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //	On the first input line – lost games count – integer in the range[0…1000].
            //•	On the second line – headset price – floating - point number in the range[0…1000].
            //•	On the third line – mouse price – floating - point number in the range[0…1000].
            //•	On the fourth line – keyboard price – floating - point number in the range[0…1000].
            //•	On the fifth line – display price – floating - point number in the range[0… 1000].

            //  Every second lost game, Petar trashes his headset.
            //  Every third lost game, Petar trashes his mouse.
            //  When Petar trashes both his mouse and headset in the same lost game, he also trashes his keyboard.
            //  Every second time, when he trashes his keyboard, he also trashes his display.

            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetCount = 0;
            int mouseCount = 0;
            int keyboardCount = 0;
            int displayCount = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    headsetCount++;
                    mouseCount++;
                    keyboardCount++;

                    if (keyboardCount % 2 == 0)
                    {
                        displayCount++;
                    }
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        headsetCount++;
                    }

                    if (i % 3 == 0)
                    {
                        mouseCount++;
                    }
                } 
            }

            double sum = (headsetCount * headsetPrice) + (mousePrice * mouseCount) + (keyboardPrice * keyboardCount) + (displayPrice * displayCount);

            Console.WriteLine($"Rage expenses: {sum:f2} lv.");

        }
    }
}
