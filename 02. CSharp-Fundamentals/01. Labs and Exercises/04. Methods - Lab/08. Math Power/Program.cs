﻿double number = double.Parse(Console.ReadLine());
int power = int.Parse(Console.ReadLine());

double result = MathPower(number, power);

Console.WriteLine(result);

static double MathPower(double number, int power)
{
    double result = 1;

	for (int i = 0; i < power; i++)
	{
		result *= number;
	}

	return result;
}