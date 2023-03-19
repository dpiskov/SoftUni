int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

int result = SmallestNumber(num1, num2, num3);
Console.WriteLine(result);

static int SmallestNumber(int num1, int num2, int num3) => Math.Min(num1, Math.Min(num2, num3));