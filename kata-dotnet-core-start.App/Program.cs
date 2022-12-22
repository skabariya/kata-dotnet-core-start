// See https://aka.ms/new-console-template for more information

using kata_dotnet_core_start.Lib;

Console.WriteLine("Hello, World!");

foreach (var number in Enumerable.Range(1, 100))
{
     var result = FizzBuzz.Get((uint)number);
     Console.WriteLine(result);
}
