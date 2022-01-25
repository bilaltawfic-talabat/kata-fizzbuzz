using Xunit;

namespace FizzBuzzWhizz.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
    }

    [Theory]
    [InlineData(1,"1")]
    [InlineData(2,"2")]
    [InlineData(3,"fizz")]
    [InlineData(5,"buzz")]
    [InlineData(15,"fizzbuzz")]
    public void CallFizzBuzzWithNumber(int input, string output)
    {
        var fizzbuzz = new FizzBuzz();
        var result = fizzbuzz.Run(input);
        Assert.Equal(output, result);
    }
}