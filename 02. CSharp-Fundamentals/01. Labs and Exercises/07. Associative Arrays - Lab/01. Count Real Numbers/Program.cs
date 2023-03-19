namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> occurrencesByNumber = new SortedDictionary<double, int>();

            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            foreach (var number in numbers)
            {
                if (!occurrencesByNumber.ContainsKey(number))
                {
                    occurrencesByNumber.Add(number, 0);
                }
                occurrencesByNumber[number]++;
            }

            foreach (var occurrenceByNumber in occurrencesByNumber)
            {
                Console.WriteLine($"{occurrenceByNumber.Key} -> {occurrenceByNumber.Value}");
            }
        }
    }
}