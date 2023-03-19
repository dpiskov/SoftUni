namespace _02._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // hi abc add

            string[] input = Console.ReadLine().Split();

            foreach (var item in input)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    Console.Write(item);
                }
            }
        }
    }
}