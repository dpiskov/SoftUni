namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            while (second.Contains(first))
            {
                int index = second.IndexOf(first);

                second = second.Remove(index, first.Length);
            }

            Console.WriteLine(second);
        }
    }
}