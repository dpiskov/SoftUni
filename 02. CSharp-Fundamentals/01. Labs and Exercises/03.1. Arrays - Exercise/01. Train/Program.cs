int wagons = int.Parse(Console.ReadLine());

int[] passengers = new int[wagons];

int totalPassengers = 0;

for (int i = 0; i < wagons; i++)
{
    passengers[i] = int.Parse(Console.ReadLine());
    totalPassengers += passengers[i];
}

Console.Write(String.Join(' ', passengers));
Console.WriteLine();
Console.WriteLine(totalPassengers);