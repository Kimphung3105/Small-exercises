namespace Small_exercises;

public class AverageCalculator
{
    public static double Average(double a, double b, double c)
    {
        return (a + b + c) / 3;
    }

    public static string Grade(double avg)
    {
        if (avg >=8)
            return "Excellent";
        else if (avg >= 6)
            return "Good";
        else if (avg >= 4)
            return "Average";
        else
            return "Poor";
    }

    public static void Run()
    {
        Console.WriteLine("Average Calculator");

        while (true)
        {
            Console.Write("Enter score 1: ");
            double s1 = double.Parse(Console.ReadLine()!);
            
            Console.Write("Enter score 2: ");
            double s2 = double.Parse(Console.ReadLine()!);
            
            Console.Write("Enter score 3: ");
            double s3 = double.Parse(Console.ReadLine()!);
            
            double avg = Average(s1, s2, s3);
            string grade = Grade(avg);
            
            Console.WriteLine($"Average is {avg:F2} - Grade: {grade}");
            
            
            Console.Write("Do you want to calculate another person? (y/n):");
            string again = Console.ReadLine().Trim().ToLower();
            if (again != "y") break;
        }
    }
}