using System;
using System.Linq;
using System.Numerics;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace _02._Array_Modify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input

            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command.Length == 3)
                {
                    int firstIndex = int.Parse(command[1]);
                    int secondIndex = int.Parse(command[2]);

                    int firstNumber = 0;
                    int secondNumber = 0;

                    //"swap {index1} {index2}"
                    if (command[0] == "swap")
                    {
                        SwapNumbers(firstNumber, secondNumber, firstIndex, secondIndex, numbers);                        
                    }
                    //"multiply {index1} {index2}"
                    if (command[0] == "multiply")
                    {
                        numbers[firstIndex] *= numbers[secondIndex];
                    }
                }
                else
                {
                    //"decrease"
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] -= 1;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", numbers));
        }

        static void SwapNumbers(int firstNumber, int secondNumber, int firstIndex, int secondIndex, int[] numbers)
        {
            firstNumber = numbers[firstIndex];
            secondNumber = numbers[secondIndex];

            numbers[firstIndex] = secondNumber;
            numbers[secondIndex] = firstNumber;
        }
    }
}