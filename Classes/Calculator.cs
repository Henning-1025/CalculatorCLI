namespace CalculatorCLI.Classes;
public class Calculator
{
    // OVERLOAD 1: Add two numbers
    public decimal Add(decimal a, decimal b)
    {
        return a + b;
    }

    // OVERLOAD 2: Add multiple numbers
    public decimal Add(params decimal[] numbers)
    {
        decimal result = 0;
        foreach (decimal number in numbers)
        {
            result += number;
        }
        return result;
    }

    // OVERLOAD 1: Subtract two numbers
    public decimal Subtract(decimal a, decimal b)
    {
        return a - b;
    }

    // OVERLOAD 2: Subtract multiple numbers
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

    // OVERLOAD 1: Multiply two numbers
    public decimal Multiply(decimal a, decimal b)
    {
        return a * b;
    }

    // OVERLOAD 2: Multiply multiple numbers
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

    // OVERLOAD 1: Divide two numbers
    public decimal Divide(decimal a, decimal b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero!");
        }
        return a / b;
    }

    // OVERLOAD 2: Divide multiple numbers
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