string input = Console.ReadLine();
int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());

PrintResult(input, firstNumber, secondNumber);

static void PrintResult(string input, int firstNumber, int secondNumber)
{
    if (input == "add")
    {
        Console.WriteLine(firstNumber + secondNumber);
    }
    else if (input == "multiply")
    {
        Console.WriteLine(firstNumber * secondNumber);
    }
    else if (input == "subtract")
    {
        Console.WriteLine(firstNumber - secondNumber);
    }
    else if (input == "divide")
    {
        Console.WriteLine(firstNumber / secondNumber);
    }
}