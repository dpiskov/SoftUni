﻿string word = Console.ReadLine();
PrintMiddleCharacters(word);

static void PrintMiddleCharacters(string? word)
{
    if (word.Length % 2 == 0)
    {
        Console.Write(word[word.Length / 2 - 1]);
        Console.WriteLine(word[word.Length / 2]);
    }
    else
    {
        Console.WriteLine(word[word.Length / 2]);
    }
}