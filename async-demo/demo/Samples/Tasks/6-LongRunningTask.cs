//namespace demo;
//class Program
//{
//    public static Task Main()
//    {
//        CancellationTokenSource cts = new CancellationTokenSource(TimeSpan.FromSeconds(2));
//        TaskFactory taskFactory = new TaskFactory();
//
//        Task longRunningTask = taskFactory.StartNew(
//            () => TimeConsumingWork(cts.Token),
//            cts.Token,
//            TaskCreationOptions.LongRunning,
//            TaskScheduler.Default);
//
//        // if you await the task it will not be longrunning any longer
//
//        return longRunningTask;
//    }
//
//    private static void TimeConsumingWork(CancellationToken ct)
//    {
//        // Very time consuming work...
//        int i = 0;
//        while (true)
//        {
//            ct.ThrowIfCancellationRequested();
//            i++;
//            Console.WriteLine($"We are on iteration number {i}");
//        }
//    }
//}