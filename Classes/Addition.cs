namespace CalculatorCLI.Classes;

public class Addition
{
    public decimal Add(params decimal[] numbers)
    {
        decimal result = 0;
        foreach (var number in numbers)
        {
            result += number;
        }
        return result;
    }
}