using System.Numerics;

public class FibonacciCalculatedEventArgs : EventArgs
{
    public TimeSpan ElapsedTime { get; set; }
    
    public BigInteger FibonacciNumber { get; set; }
}