namespace kata_dotnet_core_start.Lib;

public class FizzBuzzStage1 : FizzBuzz
{
    public override string Get(uint number)
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
}