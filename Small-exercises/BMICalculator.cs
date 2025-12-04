using System;
using System.Globalization;

namespace Small_exercises
{
    public static class BMICalulator
    {
        public static string CalculateBMI(double weight, double height)
        {
            if (height <= 0 || weight <= 0)
                throw new ArgumentException("Height and weight must be greater than 0");

            double bmi = weight / (height * height);

            if (bmi < 18.5)
                return "Underweight";
            else if (bmi <= 24.9)
                return "Normal";
            else if (bmi <= 29.9)
                return "Overweight";
            else
                return "Obese";
        }

        public static double ReadDouble(string prompt)
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

        public static void Run()
        {
            Console.WriteLine("BMI Calculalte");

            while (true)
            {
                double weightInput = ReadDouble("Enter your weight in kg: ");
                double heightInput = ReadDouble("Enter your height in m or cm: ");

                if (heightInput > 3) heightInput /= 100;

                string result = CalculateBMI(weightInput, heightInput);
                Console.WriteLine(result);

                Console.Write("Do you want to calculate another person? (y/n):");
                string again = Console.ReadLine().Trim().ToLower();
                if (again != "y") break;
                
                /* Console.Write("Enter your weight (kg): ");
                  double weightInput = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                  Console.Write("Enter your height (m): ");
                  double heightInput = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                  string result = CalculateBMI(weightInput, heightInput);
                  Console.WriteLine(result);*/
            }
        }
    }


}