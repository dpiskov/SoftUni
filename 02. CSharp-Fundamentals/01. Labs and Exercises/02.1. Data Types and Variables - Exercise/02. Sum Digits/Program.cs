int number = int.Parse(Console.ReadLine());

int numberCopy = number;

int sum = 0;

while (numberCopy != 0)
{
    sum += numberCopy % 10;
    numberCopy /= 10;
}

Console.WriteLine(sum);