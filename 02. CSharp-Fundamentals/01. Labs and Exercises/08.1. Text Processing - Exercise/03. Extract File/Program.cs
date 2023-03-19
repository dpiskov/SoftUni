namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C:\Internal\training-internal\Template.pptx

            string[] path = Console.ReadLine().Split("\\");

            string[] template = path[path.Length - 1].Split(".");

            string file = template[0];
            string extension = template[1];

            Console.WriteLine($"File name: {file}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}