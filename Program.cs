using CalculatorCLI.Classes;

namespace CalculatorCLI;
class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        bool isRunning = true;

        Console.WriteLine("=== Calculator CLI ===\n");

        while (isRunning)
        {
            DisplayMenu();

            string? choice = Console.ReadLine();

            if (choice == "5")
            {
                isRunning = false;
                Console.WriteLine("Goodbye!");
                continue;
            }

            Console.Write("Enter numbers (separated by commas or spaces): ");
            string? input = Console.ReadLine();

            decimal[] numbers = ParseNumbers(input);

            if (numbers.Length == 0)
            {
                Console.WriteLine("No valid numbers entered.\n");
                continue;
            }

            try
            {
                decimal result = 0;
                string operation = "";

                switch (choice)
                {
                    case "1":
                        result = calc.Add(numbers);
                        operation = "Addition";
                        break;
                    case "2":
                        result = calc.Subtract(numbers);
                        operation = "Subtraction";
                        break;                
                    case "3":
                        result = calc.Multiply(numbers);
                        operation = "Multiplication";
                        break;
                    case "4":
                        result = calc.Divide(numbers);
                        operation = "Division";
                        break;
                    default:
                        Console.WriteLine("Invalid Choice!\n");
                        continue;
                }

                Console.WriteLine($"{operation}: {string.Join(" ", numbers)} = {result}\n");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}\n");
            }
        }
    }
    static void DisplayMenu()
    {
        Console.WriteLine("Choose an operation:");
        Console.WriteLine("1. Addition (+)");
        Console.WriteLine("2. Subtraction (-)");
        Console.WriteLine("3. Multiplication (×)");
        Console.WriteLine("4. Division (÷)");
        Console.WriteLine("5. Exit");
        Console.Write("Your choice: ");
    }

    static decimal[] ParseNumbers(string? input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return Array.Empty<decimal>();

        // Split by comma or space
        char[] separators = { ',', ' ' };
        string[] parts = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        List<decimal> numbers = new List<decimal>();

        foreach (string part in parts)
        {
            if (decimal.TryParse(part, out decimal number))
            {
                numbers.Add(number);
            }
        }

        return numbers.ToArray();
    }
}
