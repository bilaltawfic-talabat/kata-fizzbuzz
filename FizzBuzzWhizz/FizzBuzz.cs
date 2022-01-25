namespace FizzBuzzWhizz;

public class FizzBuzz
{
    public string Run(int value)
    {
        if (value % 3 == 0)
        {
            return "fizz";
        }
        return value.ToString();
    }
}