namespace FizzBuzzWhizz;

public class FizzBuzz
{
    public string Run(int value)
    {
        var result = "";
        
        if (value % 3 == 0)
        {
            result += "fizz";
        }

        if (value % 5 == 0)
        {
            result += "buzz";
        }

        if (string.IsNullOrEmpty(result))
        {
            return value.ToString();    
        }

        return result;
    }
}