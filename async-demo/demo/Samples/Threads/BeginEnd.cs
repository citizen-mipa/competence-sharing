//namespace demo;
//
//class Program
//{
//    public static void Main()
//    {
//
//        FileStream fs = new FileStream(
//            @"../net6.0/Data/data.json",
//            FileMode.Open,
//            FileAccess.Read,
//            FileShare.Read,
//            1024,
//            FileOptions.Asynchronous);
//
//        Byte[] data = new Byte[100];
//
//        IAsyncResult ar = fs.BeginRead(data, 0, data.Length, Callback, fs);
//
//        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
//
//        ar.AsyncWaitHandle.WaitOne();
//    }
//
//    private static void Callback(IAsyncResult result)
//    {
//        FileStream fs = (FileStream)result.AsyncState!;
//        int bytesRead = fs.EndRead(result);
//
//        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
//    }
//}
