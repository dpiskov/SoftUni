using System.Numerics;

int n = int.Parse(Console.ReadLine());

decimal number = decimal.MinValue;
string bigModel = string.Empty;

for (int i = 0; i < n; i++)
{
    string model = Console.ReadLine();
    decimal radius = decimal.Parse(Console.ReadLine());
    int height = int.Parse(Console.ReadLine());

    decimal volume = (decimal)Math.PI * radius * radius * height;

    if (volume > number)
    {
        number = volume;
        bigModel = model;
    }
}

Console.WriteLine(bigModel);