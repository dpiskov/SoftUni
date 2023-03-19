//3 3 6 1 -> 6 6 1 -> 12 1

List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

for (int i = 0; i < numbers.Count - 1; i++)
{
    double num = 0;

    if (numbers[i] == numbers[i + 1])
    {
        num = numbers[i] + numbers[i + 1];
        numbers.RemoveAt(i);
        numbers.RemoveAt(i);
        numbers.Insert(i, num);
        i = -1;
    }
}

Console.WriteLine(String.Join(" ", numbers));