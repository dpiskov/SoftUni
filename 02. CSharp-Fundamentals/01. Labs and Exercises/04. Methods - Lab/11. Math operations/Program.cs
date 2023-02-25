int firstNumber = int.Parse(Console.ReadLine());
string @operator = Console.ReadLine();
int secondNumber = int.Parse(Console.ReadLine());

double result = Calculate(firstNumber, @operator, secondNumber);

Console.WriteLine(result);

static double Calculate(int a, string @operator, int b)
{
    double result = 0;

    switch (@operator)
    {
        case "+": result = (a + b) * 1.0; break;
        case "-": result = (a - b) * 1.0; break;
        case "*": result = (a * b) * 1.0; break;
        case "/": result = (a / b) * 1.0; break;
    }

    return result;
}