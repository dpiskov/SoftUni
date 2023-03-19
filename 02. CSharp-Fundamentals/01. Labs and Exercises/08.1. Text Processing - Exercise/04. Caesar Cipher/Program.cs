namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programming is cool!

            string input = Console.ReadLine();

            char[] inputToChar = input.ToCharArray();

            foreach (char item in inputToChar)
            {
                int charToInt = item + 3;
                char intToChar = (char)charToInt;

                Console.Write(intToChar);
            }

            //char ch = 'P';
            //int chara = ch + 3;
            //char chcc = (char)chara;

            //Console.WriteLine(chcc);


        }
    }
}