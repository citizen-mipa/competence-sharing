//using System.Collections.Concurrent;
//
//namespace demo;
//class Program
//{
//    // Consider if your application have a custom SynchronizationContext or if you are developing a library
//    // Ex image if the SynchronizationContext has MaxConcurrencySynchronizationContext set to a low number
//    public static Task Main()
//    {
//        Task t1 = ExecuteLibraryCodeAsync();
//        Task t2 = ExecuteLibraryCodeAsync();
//        Task t3 = ExecuteLibraryCodeAsync();
//        Task t4 = ExecuteLibraryCodeAsync();
//
//        return Task.WhenAll(t1, t2, t3, t4);
//    }
//
//    private static async Task ExecuteLibraryCodeAsync()
//    {
//        // Do not require returning to the same context after finishing executing
//        await Task.Delay(TimeSpan.FromSeconds(1)).ConfigureAwait(false);
//
//        // Some more code
//    }
//}