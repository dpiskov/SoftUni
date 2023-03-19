using System.Linq;

namespace _04._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Linux, Windows
            //It is not Linux, it is GNU / Linux.Linux is merely the kernel, while GNU adds the functionality.Therefore we owe it to them by calling the OS GNU / Linux! Sincerely, a Windows client

            //It is not *****, it is GNU/*****. ***** is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by calling the OS GNU/*****! Sincerely, a ******* client

            string[] bannedWords = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string input = Console.ReadLine();

            foreach (var item in bannedWords)
            {
                string replaced = new string('*', item.Length);
                input = input.Replace(item, replaced);
            }

            Console.WriteLine(input);
        }
    }
}