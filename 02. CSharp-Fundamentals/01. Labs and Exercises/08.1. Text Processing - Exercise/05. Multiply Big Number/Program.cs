using System.Text;

namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());
            var sb = new StringBuilder();

            int remainder = 0;

            if (multiplier == 0 || input == "0")
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = input.Length - 1; i >= 0; i--)
            {
                int currDigit = int.Parse(input[i].ToString());
                int product = currDigit * multiplier + remainder;
                int result = product % 10;
                remainder = product / 10;
                sb.Insert(0, result);
                
            }

            if (remainder > 0)
            {
                sb.Insert(0, remainder);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}