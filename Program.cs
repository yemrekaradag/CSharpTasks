
namespace MyConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Positive Number: ");

        string? input = Console.ReadLine();

        if (!input.IsPositiveNumber())
        {
            Console.WriteLine("\nPlease enter a positive number.");
            return;
        }

        int n = int.Parse(input!);
        int[] numbers = new int[n];

        Console.WriteLine($"\nPlease enter {n} numbers:");

        for (int i = 0; i < n; i++)
        {
            string? userInput = Console.ReadLine();

            if (!userInput.IsPositiveNumber())
            {
                Console.WriteLine("Please enter a positive number.");
                i--;
                continue;
            }

            numbers[i] = int.Parse(userInput!);
        }

        PrintEvenNumbers(n, numbers);
    }

    static void PrintEvenNumbers(int n, int[] numbers)
    {
        Console.WriteLine("\nEven numbers:");
        for (int i = 0; i < n; i++)
        {
            if (numbers[i] % 2 == 0)
                Console.WriteLine(numbers[i]);
        }
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
