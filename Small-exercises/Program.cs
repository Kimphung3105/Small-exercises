using System.Globalization;

namespace Øvelser;

public class Program
{
    static string CalculateBMI(double weight, double height)
    {
        if (height <= 0)
        {
            throw new ArgumentException("Height must be greater than 0");
        }

        double bmi = weight / (height * height);
        
        if (bmi < 18.5)
            return $"BMI: {bmi:F2} - Underweight";
        else if (bmi  <= 24.9)
            return $"BMI: {bmi:F2} - Normal weight";
        else if (bmi <= 29.9)
            return $"BMI: {bmi:F2} - Overweight";
        else
            return $"BMI: {bmi:F2} - Obese";
    }

    static double ReadDouble(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            input = input.Replace(',', '.');
            if (double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out double value))
                return value;
            Console.WriteLine("Invalid input!");
        }
    } 

    static void Main(string[] args)
    {
        string name = "Kim";
        int age = 27;
        double weight = 80;
        bool isLearningCSharp = true;

        Console.WriteLine(name);
        Console.WriteLine(age);
        Console.WriteLine(weight);
        Console.WriteLine(isLearningCSharp);

        if (weight >= 60)
        {
            Console.WriteLine("You are overweight");
        }
        else
        {
            Console.WriteLine("You are underweight");
        }

        Console.WriteLine("BMI Calculate");

        while (true)
        {
            double weightInput = ReadDouble("Enter weight (kg): ");
            double heightInput = ReadDouble("Enter height (m or cm): ");

            if (heightInput > 3) heightInput /= 100;
            
            string result = CalculateBMI(weightInput, heightInput);
            Console.WriteLine(result);
            
            Console.Write("Do you want to calculate another person? (y/n):");
            string again = Console.ReadLine().Trim().ToLower();
            if (again != "y") break;
        }
        
      /* Console.Write("Enter your weight (kg): ");
       double weightInput = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
       
       Console.Write("Enter your height (m): ");
       double heightInput = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

       string result = CalculateBMI(weightInput, heightInput);
       Console.WriteLine(result);*/
       

    }
}

    

    


