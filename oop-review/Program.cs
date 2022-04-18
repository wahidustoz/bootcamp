var fibonacci = new Fibonacci(1000);
fibonacci.CalculationFinished += FibonacciFinished;
fibonacci.NewFibonacciFound += NewFibonacci;

void NewFibonacci(object sender, NewFibonacciFoundEventArgs e)
{
    Console.WriteLine($"New number arrived: {e.NewFibonacciNumber}");
    
}

fibonacci.StartCalculation();

Console.ReadLine();

void FibonacciFinished(object sender, FibonacciCalculatedEventArgs e)
{
    Console.WriteLine($"{e.ElapsedTime.TotalSeconds}");
    Console.WriteLine($"{e.FibonacciNumber}");
}


// String a, b;

// a = "Hello";
// b = "Hello";

// Console.WriteLine($"{Object.ReferenceEquals(a, b)}");


// int? son = 17;
// son = null;

// Console.WriteLine($"{son}");


// public class Program
// {
//     public delegate TResult Func<TResult, T2>(T2 a);
//     public delegate bool Predicate<T1>(T1 a);
//     public delegate void Action<T1>(T1 a);

//     static int Power(int a)
//     {
//         return a * a;
//     }

//     public static void Main(string[] args)
//     {
//         var sonlar = new int[] { 10, 9, 11, 14, 5, 17, 15, 5 };

//         var kattaSonlar = sonlar.Where(Katta10dan);

//         Action<int> a = WriteSon;

//         sonlar.ToList().ForEach(Console.WriteLine);
//         // sonlar.ToList().ForEach(WriteSon);
//     }

//     static void WriteSon(int son) => Console.WriteLine($"{son}");


//     public static bool Katta10dan(int a) => a > 10;
// }






// void SayMoo()
// {
//     Console.WriteLine($"Moooooooooooo");
// }

// void SayHello() => Console.WriteLine($"Hello");


// var cow = new Animal();

// cow.SaySomething = SayMoo;
// cow.SaySomething += SayHello;
// cow.Speak();

