namespace Small_exercises;

public class EvenChecker
{
    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    public static void Run()
    {
        Console.WriteLine("Even Checker");

        while (true)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine()!);
            
            if (IsEven(number))
                Console.WriteLine($"{number} is even!");
            else
                Console.WriteLine($"{number} is odd!");
            
            Console.Write("Do you want to check another number? (y/n):");
            string again = Console.ReadLine().Trim().ToLower();
            if (again != "y") break;
            
        }
    }
}