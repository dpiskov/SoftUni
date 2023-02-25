int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

for (int i = 0; i < numbers.Length; i++)
{
    int currNum = numbers[i];

    bool isTopInteger = true;

    for (int j = i + 1; j < numbers.Length; j++)
    {
        int nextNum = numbers[j];
        if (nextNum >= currNum)
        {
            isTopInteger = false;
            break;
        }
    }

    if (isTopInteger)
    {
        Console.Write($"{currNum} ");
    }
}