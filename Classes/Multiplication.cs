namespace CalculatorCLI.Classes;

public class Multiplication
{
    public decimal Multiply(params decimal[] numbers)
    {
        decimal result = 1;
        foreach (var number in numbers)
        {
            result *= number;
        }
        return result;
    }
}