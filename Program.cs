
using System.Collections;

namespace MyConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        ArrayList numbers = new ArrayList();
        Console.Write("Enter 20 positive number: ");

        for (int i = 0; i < 20; i++)
        {
            string? input = Console.ReadLine();

            if (!input.IsPositiveNumber())
            {
                Console.WriteLine("\nPlease enter a positive number.");
                i--;
                continue;
            }

            int n = int.Parse(input!);
            numbers.Add(n);
        }

        numbers.Sort();
        int min1 = (int)numbers[0]!;
        int min2 = (int)numbers[1]!;
        int min3 = (int)numbers[2]!;

        int max1 = (int)numbers[numbers.Count - 1]!;
        int max2 = (int)numbers[numbers.Count - 2]!;
        int max3 = (int)numbers[numbers.Count - 3]!;

        double avgMin = (min1 + min2 + min3) / 3.0;
        double avgMax = (max1 + max2 + max3) / 3.0;
        double avgTotal = avgMin + avgMax;

        Console.WriteLine("\n--- Results ---");
        Console.WriteLine($"Smallest 3 numbers: {min1}, {min2}, {min3}");
        Console.WriteLine($"Largest 3 numbers: {max1}, {max2}, {max3}");
        Console.WriteLine($"Average of smallest 3: {avgMin}");
        Console.WriteLine($"Average of largest 3: {avgMax}");
        Console.WriteLine($"Sum of averages: {avgTotal}");
    }
}
static class Extensions
{
    public static bool IsPositiveNumber(this string? input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return false;

        bool isPositiveNumber = int.TryParse(input, out int number);

        return isPositiveNumber && number > 0;
    }
}