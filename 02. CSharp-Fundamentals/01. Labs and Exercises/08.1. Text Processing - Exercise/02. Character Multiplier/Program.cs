namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int sum = 0;

            string first = input[0];
            string second = input[1];



            string longestString;
            string shortestString;

            if (first.Length > second.Length)
            {
                longestString = first;
                shortestString = second;
            }
            else
            {
                longestString = second;
                shortestString = first;
            }

            for (int i = 0; i < shortestString.Length; i++)
            {
                sum += shortestString[i] * longestString[i];
            }

            for (int i = shortestString.Length; i < longestString.Length; i++)
            {
                sum += longestString[i];
            }

            Console.WriteLine(sum);
        }
    }
}