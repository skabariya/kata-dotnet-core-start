namespace kata_dotnet_core_start.Lib;
public abstract class FizzBuzz
{
    public abstract string Get(uint number);
    
    protected static bool IsMultipleOf3(uint number) => number % 3 == 0;

    protected static bool IsMultipleOf5(uint number) => number % 5 == 0;
    protected static bool Contains3(uint number) => number.ToString().Contains('3');
}
