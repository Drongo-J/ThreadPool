using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPoolLesson
{
    #region Thread Background Example
    //internal class Program
    //{
    //    static void Something()
    //    {
    //        for (int x = 0; x < 20; x++)
    //        {
    //            Console.WriteLine($"Downloading {x}");
    //            Thread.Sleep(500);
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        Thread thread = new Thread(() =>
    //        {
    //            Something();
    //        });
    //        thread.Start();
    //        thread.IsBackground = true;

    //        Thread t2 = new Thread(() =>
    //        {
    //            thread.Join();
    //            for (int i = 0; i < 100; i++)
    //            {
    //                Thread.Sleep(30);
    //                Console.WriteLine("AAAAAAAAAAAAAAAAAA");
    //            }
    //        });
    //        t2.Start();

    //        var name = Console.ReadLine();
    //        var surname = Console.ReadLine();
    //        Console.WriteLine($"Welcome {name} {surname}");

    //        for (int x = 0; x < 50; x++)
    //        {
    //            Console.WriteLine("Main Downloading . . .");
    //            Thread.Sleep(20);
    //        }
    //    }
    //}
    #endregion

    #region BeginInvoke
    //class Program
    //{
    //    delegate string SomeSpecialDelegate();

    //    public static string SomeTask()
    //    {
    //        Console.WriteLine("Some process is going");
    //        Console.WriteLine($"Some task ID : {Thread.CurrentThread.ManagedThreadId}");
    //        for (int i = 0; i < 10; i++)
    //        {
    //            Thread.Sleep(100);
    //            Console.WriteLine("New Thread Working");
    //        }
    //        return "Data";
    //    }

    //    static void Main(string[] args)
    //    {
    //        #region With Delegate
    //        //var del = new SomeSpecialDelegate(SomeTask);
    //        //Console.WriteLine($"Main Thread Id : {Thread.CurrentThread.ManagedThreadId}");
    //        ////var ar = del.Invoke(); // not async
    //        //var ar = del.BeginInvoke(null, null); // async
    //        //Console.WriteLine("RESULT");
    //        #endregion

    //        #region With Func
    //        var func = new Func<string>(SomeTask);
    //        Console.WriteLine($"Main Thread Id : {Thread.CurrentThread.ManagedThreadId}");
    //        //var ar = del.Invoke(); // not async
    //        var ar = func.BeginInvoke(null, null); // async
    //        Console.WriteLine("RESULT");
    //        #endregion

    //        for (int i = 0; i < 50; i++)
    //        {
    //            Thread.Sleep(100);
    //            Console.WriteLine("Main Working");
    //        }
    //        var result = func.EndInvoke(ar);
    //        Console.WriteLine(result);
    //    }
    //}
    #endregion

    #region ThreadPool
    class Program
    {
        //static void AsyncOperation(object state)
        //{
        //    Console.WriteLine(state.ToString());
        //    Thread.Sleep(5000);
        //    Console.WriteLine($"ID : {Thread.CurrentThread.ManagedThreadId}");
        //}


        //static void Main(string[] args)
        //{
        //    //ThreadPool.GetMaxThreads(out int a, out int b);
        //    //Console.WriteLine(a);
        //    //Console.WriteLine(b);

        //    //ThreadPool.QueueUserWorkItem(AsyncOperation, "My Data 123");
        //    //Console.ReadLine();
        //}

        static void FunctionThread(object state)
        {
            Console.WriteLine($"ID : {Thread.CurrentThread.ManagedThreadId}");
            //Thread.Sleep(1000);
            //for (int i = 0; i < 1000; i++)
            //{

            //}
        }

        static void Main(string[] args)
        {
            //for (int i = 0; i < 600; i++)
            //{
            //    Thread t = new Thread(FunctionThread);
            //    t.Start();  
            //}
            for (int i = 0; i < 600; i++)
            {
                ThreadPool.QueueUserWorkItem(FunctionThread, null);
            }
            Console.ReadKey();
        }
    }
    #endregion
}
