
using System.Collections;

namespace MyConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        ArrayList primes = new ArrayList();
        ArrayList nonPrimes = new ArrayList();
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
            if (n.IsPrime())
                primes.Add(n);
            else
                nonPrimes.Add(n);
        }

        primes.Sort();
        nonPrimes.Sort();
        primes.Reverse();
        nonPrimes.Reverse();

        int primeTotal = 0;
        int nonPrimeTotal = 0;

        foreach (int item in primes)
        {
            primeTotal += item;
            Console.WriteLine($"Prime number: {item}");
        }

        foreach (int item in nonPrimes)
        {
            nonPrimeTotal += item;
            Console.WriteLine($"Non prime number: {item}");
        }

        Console.WriteLine($"Prime count: {primes.Count}");
        Console.WriteLine($"Prime Average: {primeTotal / primes.Count}");

        Console.WriteLine($"Non prime count: {nonPrimes.Count}");
        Console.WriteLine($"Non prime Average: {nonPrimeTotal / nonPrimes.Count}");
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
    public static bool IsPrime(this int n)
    {
        if (n < 2) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;

        int sqrt = (int)Math.Sqrt(n);
        for (int i = 3; i <= sqrt; i += 2)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }
}