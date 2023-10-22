namespace FizzBuzzApp;

public static class Math
{
    public static bool IsDivisibleBy(this int number, int divisor)
        => divisor != 0 && number % divisor == 0;
}