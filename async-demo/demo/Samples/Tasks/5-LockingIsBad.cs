﻿//namespace demo;
//class Program
//{
//    public static Task Main()
//    {
//        Task<int> first = ExecuteAsync();
//
//        int firstResult = first.Result; // This is the wrong approach and will lock the thread
//
//        // Also note how 'Task<T>' is a valid return type when signature says just 'Task'
//        return first;
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