// 3 5 2 43 12 3 54 10 23
// 76 5 34 2 4 12

List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

int minCount = Math.Min(firstList.Count, secondList.Count);

for (int i = 0; i < minCount; i++)
{
    Console.Write($"{firstList[i]} ");
    Console.Write($"{secondList[i]} ");
}

if (firstList.Count > secondList.Count)
{
    for (int i = minCount; i < firstList.Count; i++)
    {
        Console.Write($"{firstList[i]} ");
    }
}
else
{
    for (int i = minCount; i < secondList.Count; i++)
    {
        Console.Write($"{secondList[i]} ");
    }
}