// See https://aka.ms/new-console-template for more information

const int NUMBER_OF_LAPS = 100;

var FizzBuzz = new FizzBuzz.FizzBuzz();

for (int i = 1; i <= NUMBER_OF_LAPS; i++)
{
    Console.WriteLine(FizzBuzz.PrintFizzBuzz(i));
}