namespace FizzBuzzApp;
public class App
{
    private readonly Action<string> _outputAction;
    public App(Action<string> outputAction) => _outputAction = outputAction;

    public void OutputFizzBuzz()
    {
        foreach (var number in Enumerable.Range(1, 100))
            _outputAction(FizzBuzz.ToString(number));
    }
}