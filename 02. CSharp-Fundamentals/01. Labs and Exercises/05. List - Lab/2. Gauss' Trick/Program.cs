List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

List<int> endList = new List<int>();

for (int i = 0; i < numbers.Count / 2; i++)
{
    endList.Add(numbers[i] + numbers[numbers.Count - i - 1]);

}

if (numbers.Count % 2 != 0)
{
    endList.Add(numbers[numbers.Count / 2]);

}

Console.WriteLine(String.Join(" ", endList));