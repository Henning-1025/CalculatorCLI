namespace CalculatorCLI.Classes;
public class Calculator
{
  public decimal Add(params decimal[] numbers)
    {
        decimal result = 0;
        foreach (decimal number in numbers)
        {
            result += number;
        }
        return result;
    }
    public decimal Subtract(params decimal[] numbers)
    {
        if (numbers.Length == 0) return 0;

        decimal result = numbers[0];
        
        for (int i = 1; i < numbers.Length; i++)
        {
            result -= numbers[i];
        }
        return result;
    }
    public decimal Multiply(params decimal[] numbers)
    {
        if (numbers.Length == 0) return 0;

        decimal result = numbers[0];
        
        for (int i = 1; i < numbers.Length; i++)
        {
            result *= numbers[i];
        }
        return result;
    }
    public decimal Divide(params decimal[] numbers)
    {
        if (numbers.Length == 0) return 0;

        decimal result = numbers[0];
        
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero!");
            }
            result /= numbers[i];
        }
        return result;
    }
}