List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

string input;

while ((input = Console.ReadLine()) != "end")
{

    string[] command = input.Split();
    int number = int.Parse(command[1]);
    

    switch (command[0])
    {
        case "Add":
            numbers.Add(number);
            break;
        case "Remove":
            numbers.Remove(number);
            break;
        case "RemoveAt":
            numbers.RemoveAt(number);
            break;
        case "Insert":
            int index = int.Parse(command[2]);
            numbers.Insert(index, number);
            break;
    }
}


Console.WriteLine(String.Join(" ", numbers));