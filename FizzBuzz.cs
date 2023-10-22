namespace FizzBuzzApp;
public static class FizzBuzz
{
    private const int FizzNumber = 3;
    private const int BuzzNumber = 5;
    public static string ToString(int number) => number switch
    {
        _ when number.IsDivisibleBy(FizzNumber * BuzzNumber) => "FizzBuzz",
        _ when number.IsDivisibleBy(FizzNumber) => "Fizz",
        _ when number.IsDivisibleBy(BuzzNumber) => "Buzz",
        _ => number.ToString()
    };
}