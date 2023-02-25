string[] elements = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

Array.Reverse(elements);

Console.WriteLine(string.Join(" ", elements));