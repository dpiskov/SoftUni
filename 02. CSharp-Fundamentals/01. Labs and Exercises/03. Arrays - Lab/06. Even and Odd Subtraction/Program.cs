int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

int even = 0;
int odd = 0;

foreach (var number in numbers)
{
    if (number % 2 == 0)
    {
        even += number;
    }
    else
    {
        odd += number;
    }
}

Console.WriteLine(even - odd);