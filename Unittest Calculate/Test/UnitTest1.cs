namespace Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestAdd()
    {
        int num1 = 2;
        int num2 = 3;
        double expected = 5;

        Calculate calculate = new();

        double result = calculate.add(num1, num2);

        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void TestSubtraction()
    {
        int num1 = 2;
        int num2 = 3;
        double expected = -1;

        Calculate calculate = new();

        double result = calculate.subtract(num1, num2);

        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void TestMultiply()
    {
        int num1 = 2;
        int num2 = 3;
        double expected = 6;

        Calculate calculate = new();

        double result = calculate.multiply(num1, num2);

        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void TestDivide()
    {
        int num1 = 2;
        int num2 = 4;
        double expected = .5;

        Calculate calculate = new();

        double result = calculate.divide(num1, num2);

        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void TestDivideByZero()
    {
        int num1 = 2;
        int num2 = 0;

        Calculate calculate = new();

        try
        {
            calculate.divide(num1, num2);   
        }
        catch(DivideByZeroException)
        {
            Assert.Pass();   
        }

        Assert.Fail();
    }
}
