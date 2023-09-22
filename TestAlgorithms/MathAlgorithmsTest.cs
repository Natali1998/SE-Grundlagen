using Algorithms;
namespace TestAlgorithms;

public class MathAlgorithmsTest
{
    public void TestFactorial_Default()
    {
        var n = 5;
        var expected = 120;

        Assert.Equal(expected,MathAlgorithms.Factorial(n));
    }
    [Fact]
    public void TestFactorial_LongOutput()
    {
        var n = 8;
        var expected = 40_320;

        Assert.Equal(expected, MathAlgorithms.Factorial(n));
    }
}