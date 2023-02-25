int n = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= n; i++)
{
    int num = i;

    while (i > 0)
    {
        sum += i % 10;
        i = i / 10;
    }

    if (sum == 5 || sum == 7 || sum == 11)
    {
    Console.WriteLine($"{num} -> True");
    }
    else
    {
        Console.WriteLine($"{num} -> False");

    }

    sum = 0;

    i = num;
}
