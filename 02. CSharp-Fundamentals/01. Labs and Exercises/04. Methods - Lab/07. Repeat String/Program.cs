string input = Console.ReadLine();
int count = int.Parse(Console.ReadLine());

string result = RepeatString(input, count);

Console.WriteLine(result);



static string RepeatString(string input, int count)
{
	string result = string.Empty;

	for (int i = 0; i < count; i++)
	{
		result = result + input;
	}

	return result;
}