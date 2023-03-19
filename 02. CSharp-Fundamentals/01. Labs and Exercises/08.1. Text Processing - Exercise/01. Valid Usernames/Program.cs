namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            bool isValid = false;

            foreach (string item in names)
            {
                if (!(item.Length < 3 || item.Length > 16))
                {
                    foreach (char ch in item)
                    {
                        if (!(char.IsLetter(ch) || char.IsDigit(ch) || ch == '-' || ch == '_'))
                        {
                            isValid = false;
                            break;
                        }
                        else
                        {
                            isValid = true;
                        }
                    }
                }
              
                if (isValid)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}