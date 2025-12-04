using System.Runtime.InteropServices.Marshalling;

namespace Small_exercises;

public class SumCalculator
{
        public static void Run()
        {
            Console.WriteLine("Sum of Array Elements");

            while (true)
            {
                Console.Write("Enter array size: ");
                int size = int.Parse(Console.ReadLine()!);
                int[] numbers = new int[size];

                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Enter number {i + 1}: ");
                    numbers[i] = int.Parse(Console.ReadLine()!);
                }

                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
                
                Console.WriteLine($"Sum = {sum}");
                
                Console.Write("Do you want to try again? (y/n):");
                if(Console.ReadLine().Trim().ToLower() != "y") break;
            }
        }
}

public class MaxFinder
{
    public static void Run()
    {
        Console.WriteLine("Finde Maximum Number");

        while (true)
        {
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine()!);
            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine()!);
            }

            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                    max = numbers[i];
            }
            
            Console.WriteLine($"Maximum number = {max}");
            
            Console.WriteLine("Do you want to try again? (y/n): ");
            if(Console.ReadLine().Trim().ToLower() != "y") break;
        }
    }
}

public class EvenCounter
{
    public static void Run()
    {
        Console.WriteLine("Count Numbers Divisiblle by 2");

        while (true)
        {
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine()!);
            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine()!);
            }

            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                    count++;
            }
            
            Console.WriteLine($"Numbers divisible by 2 = {count}");
            
            Console.Write("Do you want to try again? (y/n): ");
            if (Console.ReadLine().Trim().ToLower() != "y") break;
        }
    }
}

public class EvenPrinter
{
    public static void Run()
    {
        Console.WriteLine("Print Even Numbers");

        while (true)
        {
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine()!);
            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine()!);
            }
            
            Console.Write("Even numbers: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 2 == 0)
                    Console.Write(numbers[i] + " , ");
            }
            
            Console.WriteLine();
            
            Console.Write("Do you want to try again? (y/n): ");
            if (Console.ReadLine().Trim().ToLower() != "y") break;
        }
    }
}

public class AverageCalculatorArray
{
    public static void Run()
    {
        Console.WriteLine("Average of Array Elements");

        while (true)
        {
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine()!);
            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine()!);
            }

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            double average = (double)sum / numbers.Length;
            Console.WriteLine($"Aerage = {average:F2}");
            
            Console.Write("Do you want to try again? (y/n): ");
            if (Console.ReadLine().Trim().ToLower() != "y") break;
        }
    }
}
