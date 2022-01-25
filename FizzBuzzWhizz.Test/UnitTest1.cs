using Xunit;

namespace FizzBuzzWhizz.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
    }

    [Fact]
    public void CallFizzBuzzWithNumber()
    {
        var fizzbuzz = new FizzBuzz();
        var result = fizzbuzz.Run(1);
        Assert.Equal(1, result);
    }
}