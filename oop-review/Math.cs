public class Math
{
    public delegate double AddDelegate(double a, double b);
    public AddDelegate Adder { get; set; }
}