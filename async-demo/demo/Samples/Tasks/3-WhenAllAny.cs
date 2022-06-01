//namespace demo;
//
//class Program
//{
//    private static readonly Random NumberGenerator = new Random();
//
//    public static async Task Main()
//    {
//        var t1 = ExecuteAsync("first");
//        var t2 = ExecuteAsync("second");
//        var t3 = ExecuteAsync("third");
//
//        Task<Task<string>> anyTaskFinished = Task.WhenAny(t1, t2, t3);
//
//        Task<string[]> allTasksFinished = Task.WhenAll(t1, t2, t3);
//
//        string nameOfWinner = (await anyTaskFinished).Result;
//
//        Console.WriteLine(nameOfWinner);
//
//        await allTasksFinished;
//    }
//
//    private static async Task<string> ExecuteAsync(string name)
//    {
//        await Task.Delay(TimeSpan.FromSeconds(NumberGenerator.Next(1, 3)));
//
//        return name;
//    }
//}