using System.Numerics;

public class Fibonacci
{
    private int _index;

    public event EventHandler<FibonacciCalculatedEventArgs> CalculationFinished;
    public event EventHandler<NewFibonacciFoundEventArgs> NewFibonacciFound;
    
    
    public Fibonacci(int index)
    {
        _index = index;
    }

    public void StartCalculation()
    {
        Calculate();
    }

    private async Task Calculate()
    {
        BigInteger a = 0;
        BigInteger b = 1;
        BigInteger c = a + b;

        var startTime = DateTime.Now;

        for(int i = 3; i <= _index; i++)
        {
            c = a + b;
            NewFibonacciFound?.Invoke(this, new NewFibonacciFoundEventArgs() { NewFibonacciNumber = c });

            b = c;
            a = b;
            Thread.Sleep(100);
        }

        CalculationFinished?.Invoke(this, new FibonacciCalculatedEventArgs()
        {
            ElapsedTime = DateTime.Now - startTime,
            FibonacciNumber = c
        });
    }
}