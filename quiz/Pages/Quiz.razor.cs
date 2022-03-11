namespace quiz.Pages;

public partial class Quiz
{
    public string Title { get; set; } = "Quiz app";

    public int TimeLeft { get; set; } = 100;

    public int TimeInSeconds { get; set; } = 10;

    private DateTime startTime = new DateTime();

    protected override void OnInitialized()
    {
        Console.WriteLine($"called");
        StartTimer();
    }

    private void StartTimer()
    {
        var timer = new System.Timers.Timer(TimeSpan.FromSeconds(TimeInSeconds).TotalSeconds);
        timer.AutoReset = true;
        timer.Elapsed += ResizeProgress;
        timer.Start();
        startTime = DateTime.Now;
    }

    private void ResizeProgress(object sender, System.Timers.ElapsedEventArgs e)
    {
        var timePassed = (e.SignalTime - startTime).TotalSeconds;
        var timeLeft = TimeInSeconds - timePassed;
        TimeLeft = Math.Max(0, (int)(timeLeft / (double)TimeInSeconds * 100));
        StateHasChanged();
    }
}