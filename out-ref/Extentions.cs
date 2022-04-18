public static class Xusan
{
    public static void Print(this Product p, string note = "")
        => Console.WriteLine($"Name: {p.ItemName}, Id: {p.ItemID}, Note: {note}");

    public static void PrintAll<T>(this List<T> list)
    {
        list.ForEach(i => Console.WriteLine($"{i}"));
    }
}