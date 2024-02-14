namespace CalculatorLibrary;

public class Calculator
{
    public decimal Add(decimal number1, decimal number2)
    {
        return number1 + number2;
    }
    public decimal Subtract(decimal number1, decimal number2)
    {
        return number1 - number2;
    }
    public decimal Multiply(decimal number1, decimal number2)
    {
        return number1 * number2;
    }
    public decimal Divide(decimal number1, decimal number2)
    {
        if(number2 ==0)
        {
            throw new ArgumentException("Can't divided by zero");
        }
        return number1 / number2;
    }
    public decimal Modulo(decimal number1, decimal number2)
    {
        if(number2 ==0)
        {
            throw new ArgumentException("Can't find modulo");
        }
        return number1 % number2;
    }
    

}
