namespace kata_dotnet_core_start.Lib;
public static class FizzBuzz
{
    public static string Get(int number)
    {
        if (number % 3 == 0)
            return "Fizz";
        
        return number.ToString();
    }
}
