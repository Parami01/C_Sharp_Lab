using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        int vowelCount = CountVowels(input);

        Console.WriteLine($"Number of vowels in the given string: {vowelCount}");
    }

    static int CountVowels(string str)
    {
        int count = 0;
        string vowels = "AEIOUaeiou";

        foreach (char ch in str)
        {
            if (vowels.Contains(ch))
            {
                count++;
            }
        }

        return count;
    }
}
