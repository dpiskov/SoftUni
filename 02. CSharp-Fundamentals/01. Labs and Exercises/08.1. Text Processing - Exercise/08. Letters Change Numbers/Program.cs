namespace _08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;

            foreach (string item in input)
            {
                char firstLetter = item[0];
                char lastLetter = item[^1];

                string numAsAString = item[1..^1];

                double numFromString = double.Parse(numAsAString);

                if (char.IsUpper(firstLetter))
                {
                    int posOfLetter = firstLetter - 64;
                    numFromString /= posOfLetter;
                }
                else
                {
                    int posOfLetter = firstLetter - 96;
                    numFromString *= posOfLetter;
                }

                if (char.IsUpper(lastLetter))
                {
                    int posOfLetter = lastLetter - 64;
                    numFromString -= posOfLetter;
                }
                else
                {
                    int posOfLetter = lastLetter - 96;
                    numFromString += posOfLetter;
                }

                sum += numFromString;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}