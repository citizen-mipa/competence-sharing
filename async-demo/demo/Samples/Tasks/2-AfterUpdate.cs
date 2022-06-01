//namespace demo;
//class Program
//{
//    // Reminder: Look at anatomy of a task
//    public static async Task Main()
//    {
//        int bytesRead = await ExecuteAsync();
//
//        Console.WriteLine(bytesRead);
//    }
//
//    // Returning the task
//    private static Task<int> ExecuteAsync()
//    {
//        using FileStream fs = new FileStream(
//            @"../net6.0/Data/data.json",
//            FileMode.Open,
//            FileAccess.Read,
//            FileShare.Read,
//            1024,
//            FileOptions.Asynchronous);
//
//        Byte[] data = new Byte[100];
//
//        return fs.ReadAsync(data, 0, data.Length);
//    }
//
//    // Using await with return value
//    private static async Task<int> ExecuteAsync2()
//    {
//        using FileStream fs = new FileStream(
//            @"../net6.0/Data/data.json",
//            FileMode.Open,
//            FileAccess.Read,
//            FileShare.Read,
//            1024,
//            FileOptions.Asynchronous);
//
//        Byte[] data = new Byte[100];
//
//        int bytesRead = await fs.ReadAsync(data, 0, data.Length);
//
//        Console.WriteLine($"read {bytesRead} bytes");
//
//        return bytesRead;
//    }
//
//    // Using await without return value
//    private static async Task ExecuteAsync3()
//    {
//        using FileStream fs = new FileStream(
//            @"../net6.0/Data/data.json",
//            FileMode.Open,
//            FileAccess.Read,
//            FileShare.Read,
//            1024,
//            FileOptions.Asynchronous);
//
//        Byte[] data = new Byte[100];
//
//        await fs.ReadAsync(data, 0, data.Length);
//
//        Console.WriteLine($"read {bytesRead} bytes");
//    }
//}