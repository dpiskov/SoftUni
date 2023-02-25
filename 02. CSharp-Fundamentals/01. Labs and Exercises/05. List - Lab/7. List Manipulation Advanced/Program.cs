using System.Collections.Generic;
using System.ComponentModel;

List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

List<int> filtered = new List<int>();

// 5 34 678 67 5 563 98
// Filter >= 21


string input;
bool isChanged = false;

while ((input = Console.ReadLine()) != "end")
{

    string[] command = input.Split();

    if (command.Length > 1)
    {

        switch (command[0])
        {
            case "Add":
                numbers.Add(int.Parse(command[1]));
                isChanged = true;
                break;
            case "Remove":
                numbers.Remove(int.Parse(command[1]));
                isChanged = true;
                break;
            case "RemoveAt":
                numbers.RemoveAt(int.Parse(command[1]));
                isChanged = true;
                break;
            case "Insert":
                int number = int.Parse(command[1]);
                int index = int.Parse(command[2]);
                numbers.Insert(index, number);
                isChanged = true;
                break;
        }
    }


    //Contains { number} – check if the list contains the number and if so - print "Yes", otherwise print "No such number".
    //PrintEven – print all the even numbers, separated by a space.
    //PrintOdd – print all the odd numbers, separated by a space.
    //GetSum – print the sum of all the numbers.
    //Filter { condition}{ number} – print all the numbers that fulfill the given condition.
    //The condition will be either '<', '>', ">=", "<=".    

    if (command[0] == "Contains")
    {
        int number = int.Parse(command[1]);

        isContaining(numbers, number);
        //Console.WriteLine("Yes");
    }

    if (command[0] == "PrintEven")
    {
        PrintEven(numbers);
    }

    if (command[0] == "PrintOdd")
    {
        PrintOdd(numbers);
    }

    if (command[0] == "GetSum")
    {
        int sum = 0;
        sum = GetSum(numbers, sum);
        Console.WriteLine(sum);
    }

    if (command[0] == "Filter")
    {
        int number = int.Parse(command[2]);

        if (command[1] == "<")
        {
            filtered = numbers.Where(n => n < number).ToList();
        }
        else if (command[1] == ">")
        {
            filtered = numbers.Where(n => n > number).ToList();
        }
        else if (command[1] == ">=")
        {
            filtered = numbers.Where(n => n >= number).ToList();
        }
        else if (command[1] == "<=")
        {
            filtered = numbers.Where(n => n <= number).ToList();
        }

        Console.WriteLine(String.Join(" ", filtered));

    }
}

if (isChanged)
{
    Console.WriteLine(String.Join(" ", numbers));
}



static void isContaining(List<int> numbers, int number)
{
    if (numbers.Contains(number))
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No such number");
    }
}

static void PrintEven(List<int> numbers)
{
    for (int i = 0; i < numbers.Count; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            Console.Write($"{numbers[i]} ");
        }
    }
    Console.WriteLine();
}

static void PrintOdd(List<int> numbers)
{
    for (int i = 0; i < numbers.Count; i++)
    {
        if (numbers[i] % 2 != 0)
        {
            Console.Write($"{numbers[i]} ");
        }
    }
    Console.WriteLine();
}

static int GetSum(List<int> numbers, int sum)
{
    for (int i = 0; i < numbers.Count; i++)
    {
        sum += numbers[i];
    }

    return sum;
}