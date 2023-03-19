namespace _07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //abv>1>1>2>2asdasd

            string input = Console.ReadLine();

            int explosion = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (explosion > 0 && input[i] != '>')
                {
                    input = input.Remove(i, 1);
                    explosion--;
                    i--;
                }
                else if (input[i] == '>')
                {
                    explosion += int.Parse(input[i + 1].ToString());
                }
            }

                Console.WriteLine(input);                     
        }
    }
}