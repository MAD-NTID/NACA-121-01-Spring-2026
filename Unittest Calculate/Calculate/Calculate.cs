public class Calculate
{
    public double add(double num1, double num2)
    {
        return num1 + num2;
    }

    public double subtract(double num1, double num2)
    {
        return num1 - num2;
    }

    public double multiply(double num1, double num2)
    {
        return num1 * num2;
    }

    public double divide(double num1, double num2)
    {
        if(num2 == 0)
            throw new DivideByZeroException("Can't Divide by Zero");

        return num1 / num2;
    }
}