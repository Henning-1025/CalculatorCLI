namespace CalculatorCLI.Classes;

public class Subtraction
{
    public decimal Subtract(params decimal[] numbers)
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
                result -= numbers[i];
            }
        }
        return result;
    }
}