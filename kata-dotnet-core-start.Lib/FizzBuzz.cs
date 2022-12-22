namespace kata_dotnet_core_start.Lib;
public static class FizzBuzz
{
    public static string Get(uint number)
    {
        if(number is 0)
            return number.ToString();

        if (IsMultipleOf3(number) && IsMultipleOf5(number))
            return "FizzBuzz";
        
        if (IsMultipleOf3(number))
            return "Fizz";

        if (IsMultipleOf5(number))
            return "Buzz";
        
        return number.ToString();
    }

    private static bool IsMultipleOf3(uint number)
    {
        return number % 3 == 0;
    }

    private static bool IsMultipleOf5(uint number)
    {
        return number % 5 == 0;
    }
}
