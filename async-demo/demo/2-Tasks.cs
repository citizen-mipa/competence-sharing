using System;
namespace demo;

class Program2
{
    //public static Task Main(string[] args)
    //{
    //    return WriteToConsole("Message #1");
    //}

    public static Task WriteToConsole(string message)
    {
        return Task.Run(() => Console.WriteLine(message));

        //var task = new Task(() => Console.WriteLine(message));
        //task.Start();
    }
}