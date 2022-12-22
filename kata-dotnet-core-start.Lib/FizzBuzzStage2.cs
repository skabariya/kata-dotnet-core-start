namespace kata_dotnet_core_start.Lib;

public class FizzBuzzStage2 : FizzBuzz
{
    public override string Get(uint number)
    {
        if (IsMultipleOf3(number) || Contains3(number))
            return "Fizz";
        return number.ToString();
    }
}