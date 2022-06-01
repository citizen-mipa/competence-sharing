//namespace demo;
//
//class Program
//{
//    public static Task Main()
//    {
//        return ExecuteAsync().ContinueWith(t => Console.WriteLine(t.Result));
//    }
//
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
//}