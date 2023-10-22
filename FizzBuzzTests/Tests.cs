using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzApp;

namespace FizzBuzzTests;

[TestClass]
public class Tests
{
    private static readonly int[] FizzBuzzNumbers = { 15, 30, 45, 60, 75, 90 };
    private static readonly int[] RegularNumbers = { 1, 2, 4, 88, 77, 37, 98 };
    private static readonly int[] BuzzNumbers = { 5, 10, 20, 40, 85, 70, 95 };
    private static readonly int[] FizzNumbers = { 3, 6, 9, 12, 33, 66, 99 };

    [TestMethod]
    public void TestApp()
    {
        var outputValues = new List<string>();
        new App(outputValues.Add).OutputFizzBuzz();
        Assert.AreEqual(100, outputValues.Count);

        for (var index = 0; index < outputValues.Count; index++)
        {
            var originalNumber = index + 1; // because list is zero indexed
            var expectedOutput = GetExpectedOutput(originalNumber);
            if (string.IsNullOrEmpty(expectedOutput)) continue;
            var actualOutput = outputValues[index];
            Assert.AreEqual(expectedOutput, actualOutput, $"for number {originalNumber}");
        }
    }

    private static string GetExpectedOutput(int number) => number switch
    {
        _ when RegularNumbers.Contains(number) => number.ToString(),
        _ when FizzBuzzNumbers.Contains(number) => "FizzBuzz",
        _ when FizzNumbers.Contains(number) => "Fizz",
        _ when BuzzNumbers.Contains(number) => "Buzz",
        _ => ""
    };
}