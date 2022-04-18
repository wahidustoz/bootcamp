public class Animal
{
    public string Color { get; set; }

    public delegate void Say();

    public Say SaySomething { get; set; }

    public void Speak()
    {
        SaySomething?.Invoke();
        // SaySomething();
    }
}