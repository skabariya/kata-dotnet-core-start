// See https://aka.ms/new-console-template for more information

using kata_dotnet_core_start.Lib;

Console.WriteLine("Hello, World!");

var fizzBuzzStage1 = new FizzBuzzStage1();

foreach (var number in Enumerable.Range(1, 100))
{
     var result = fizzBuzzStage1.Get((uint)number);
     Console.WriteLine(result);
}
