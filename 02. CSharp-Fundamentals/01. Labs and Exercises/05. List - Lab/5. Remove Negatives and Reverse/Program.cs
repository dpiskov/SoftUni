//10 -5 7 9 -33 50 |||	50 9 7 10

using System.Collections.Generic;
using System;

List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

for (int i = 0; i < numbers.Count; i++)
{
    if (numbers[i] < 0)
    {
        numbers.RemoveAt(i);
        i--;
    }
}

numbers.Reverse();

if (numbers.Count == 0)
{
    Console.WriteLine("empty");
}

Console.WriteLine(String.Join(" ", numbers));