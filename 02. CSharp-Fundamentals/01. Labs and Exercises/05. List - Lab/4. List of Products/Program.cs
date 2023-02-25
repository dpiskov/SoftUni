//4
//Potatoes
//Tomatoes
//Onions
//Apples

int n = int.Parse(Console.ReadLine());

List<string> input = new List<string>();

for (int i = 0; i < n; i++)
{
    input.Add(Console.ReadLine());
}

input.Sort();

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"{i}.{input[i - 1]}");
}