namespace Small_exercises;

public static class AgeCalculator
{
    public static int CalculateAge(int bỉthYear)
    {
        int currentYear = DateTime.Now.Year;
        return currentYear - bỉthYear;
    }

    public static void Run()
    {
        Console.WriteLine("Age Calculator");

        while (true)
        {
            Console.Write("Enter your birth year: ");
            int birthYear = int.Parse(Console.ReadLine()!);
            
            int age = CalculateAge(birthYear);
            Console.WriteLine($"Your age is {age}");
            
            Console.Write("Do you want to calculate another person? (y/n):");
            string again = Console.ReadLine().Trim().ToLower();
            if (again != "y") break;
        }
    }
}