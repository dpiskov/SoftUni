namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //aaaaabbbbbcdddeeeedssaa

            string input = Console.ReadLine();

            Console.Write(input[0]);

            int i = 0;

            while (i + 1 < input.Length)
            {
                if (input[i] == input[i + 1])
                {
                    i++;
                    continue;
                }
                else
                {
                    Console.Write(input[i + 1]);
                }

                i++;
            }
        }
    }
}