int firstNum = int.Parse(Console.ReadLine());
int secondNum = int.Parse(Console.ReadLine());
double firstResult = Factorial(firstNum);
double secondResult = Factorial(secondNum);
Console.WriteLine($"{firstResult / secondResult:f2}");

static double Factorial(int number)
{
    double result = 1;

    while (number != 1)
    {
        result *= number;
        number--;
    }

    return result;
}