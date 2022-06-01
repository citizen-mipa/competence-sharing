namespace demo;

class Program
{
    public static void Main()
    {
        var thread = new Thread(Execute);
        thread.Start();

        //ThreadPool.QueueUserWorkItem(ExecuteUsingThreadPool);

        Thread.Sleep(1000);

        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
    }

    private static void Execute()
    {
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
    }

    private static void ExecuteUsingThreadPool(Object stateInfo)
    {
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
    }
}
