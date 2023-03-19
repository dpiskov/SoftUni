namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                char[] reversed = input.Reverse().ToArray();

                Console.WriteLine($"{input} = {string.Join("", reversed)}");


                input = Console.ReadLine();
            }
        }
    }
}