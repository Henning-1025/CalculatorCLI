namespace CalculatorCLI.Classes;

public class Division
{
    public decimal Divide(params decimal[] numbers)
    {
        decimal result = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i == 0)
            {
                result = numbers[i];
            }
            else
            {
                if (numbers[i] == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                    return 0;
                }
                result /= numbers[i];
            }
        }
        return result;
    }
}