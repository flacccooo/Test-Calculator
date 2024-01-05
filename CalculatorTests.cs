using Xunit;
namespace calc3;

public class CalculatorTest
{
    [Fact]
    public void TestAddition()
    {
        // Given
        Calculator calc = new Calculator();
        int a = 5;
        int b = 2;
        int expectedResult = 7;

        // When
        int result = calc.Add(a, b);

        // Then
        Assert.Equal(expectedResult, result);
    }
    [Fact]
    public void TestSubtraction()
    {
        //Given
        Calculator calc = new Calculator();
        int a = 5;
        int b = 2;
        int expectedresult = 3;

        //When
        int result = calc.subtract(a, b);

        //Then
        Assert.Equal(expectedresult, result);
    }
    [Fact]
    public void TestMultiply()
    {

        //Given
        Calculator calc = new Calculator();
        int a = 5;
        int b = 2;
        int expectedresult = 10;

        //When
        int result = calc.multiply(a, b);

        //Then
        Assert.Equal(expectedresult, result);
    }
       [Fact]
    public void TestDivision()
    {

        //Given
        Calculator calc = new Calculator();
        double a = 5;
        double b = 2;
        double expectedresult = 2.5;

        //When
        double result = calc.division(a, b);

        //Then
        Assert.Equal(expectedresult, result);
    }
}