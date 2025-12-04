namespace Small_exercises;

public class MiniProgram
{
    public static void SayHello(string name)
    {
        Console.WriteLine($"Hello {name}");
    }
    
    public static double Square(double number)
    {
        return number * number;
    }

    public static string CheckTemperature(double temp)
    {
        if (temp >= 37)
            return "Hot";
        else if (temp >= 32)
            return "Warm";
        else
            return "Cold";
    }

    public static void Run()
    {
        while (true)
        {
            Console.WriteLine("Choose function: ");
            Console.WriteLine("1. Say Hello");
            Console.WriteLine("2. Square a number");
            Console.WriteLine("3. Check temperature");
            Console.WriteLine("4. Exit");
            
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine()!.Trim();
            
            switch (choice){
                case "1":
                    Console.Write("Enter your name: ");
                    string name = Console.ReadLine()!;
                    SayHello(name);
                    break;
                    
                case "2":
                    Console.Write("Enter a number: ");
                    double num = double.Parse(Console.ReadLine()!);
                    Console.WriteLine($"The square of {num} is {Square(num)}");
                    break;
                
                case "3":
                    Console.Write("Enter temperature: ");
                    double temp = double.Parse(Console.ReadLine()!);
                    Console.WriteLine($"Temperature is {CheckTemperature(temp)}");
                    break;
                
                case "4":
                    return;
                
                default:
                    Console.WriteLine("Invalid choice");
                    break;
                    
            }
            
            Console.WriteLine();
        }
    }
}