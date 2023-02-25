int firstNum = int.Parse(Console.ReadLine());
int lastNum = int.Parse(Console.ReadLine());

for (int i = firstNum; i <= lastNum; i++)
{
    Console.Write($"{(char)i} ");
}