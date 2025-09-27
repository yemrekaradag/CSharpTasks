
namespace MyConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        Task1();
        Task2();
        Task3();
        Task4();
    }

    static void Task1()
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
    static void Task2()
    {
        Console.Write("Enter Positive Number: ");

        string? input = Console.ReadLine();

        if (!input.IsPositiveNumber())
        {
            Console.WriteLine("\nPlease enter a positive number.");
            return;
        }

        Console.Write("Enter Positive Number2: ");

        string? input2 = Console.ReadLine();

        if (!input2.IsPositiveNumber())
        {
            Console.WriteLine("\nPlease enter a positive number.");
            return;
        }

        int n = int.Parse(input!);
        int m = int.Parse(input2!);
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

        PrintDivisorsOrEqual(m, numbers);
    }
    static void Task3()
    {
        Console.Write("Enter Positive Number: ");

        string? input = Console.ReadLine();

        if (!input.IsPositiveNumber())
        {
            Console.WriteLine("\nPlease enter a positive number.");
            return;
        }

        int n = int.Parse(input!);
        string[] words = new string[n];

        Console.WriteLine($"\nPlease enter {n} words:");

        for (int i = 0; i < n; i++)
        {
            string? userInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("Please enter a word.");
                i--;
                continue;
            }

            words[i] = userInput;
        }

        PrintWords(words);
    }
    static void Task4()
    {
        Console.Write("Enter a sentence: ");
        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("\nPlease enter a sentence.");
            return;
        }

        string[] arr = input.Split(' ');
        Console.WriteLine($"Total word count: {arr.Length}");

        int letterCount = input.Replace(" ", "").Length;
        Console.WriteLine($"Total letter count: {letterCount}");
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
    static void PrintDivisorsOrEqual(int m, int[] numbers)
    {
        Console.WriteLine($"Numbers equal to or divisible by {m}:");
        foreach (int number in numbers)
        {
            if (number == m || m % number == 0)
            {
                Console.WriteLine(number);
            }
        }
    }
    static void PrintWords(string[] words)
    {
        Array.Reverse(words);

        foreach (string word in words)
        {
            Console.WriteLine(word);
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
