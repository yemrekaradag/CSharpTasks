
using System.Collections;

namespace MyConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a sentence: ");

        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.Write("This is not sentence.");
            return;
        }

        input.ToLower();
        char[] vowels = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };

        char[] foundVowels = new char[input.Length];
        int index = 0;

        foreach (char c in input)
        {
            if (Array.Exists(vowels, letter => letter == c))
            {
                foundVowels[index] = c;
                index++;
            }
        }

        char[] result = new char[index];
        Array.Copy(foundVowels, result, index);

        Array.Sort(result);

        Console.WriteLine("\nVowels: ");
        foreach (char h in result)
        {
            Console.Write(h + " ");
        }
    }
}