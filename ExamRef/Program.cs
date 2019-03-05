using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExamRef
{
    class Program
    {
        #region 1.1
        //public static void ThreadMethod()
        //{
        //    for(int i = 0; i < 10;i++)
        //    {
        //        Console.WriteLine("ThreadProc {0}",i);
        //        Thread.Sleep(1000);
        //    }
        //}

        //public static void ThreadMethod(object o)
        //{
        //    for (int i = 0; i < (int)o; i++)
        //    {
        //        Console.WriteLine("ThreadProc: {0}",i);
        //        Thread.Sleep(0);
        //    }
        //}

        //// [ThreadStatic]
        //public static int _field;
        #endregion

        static void Main(string[] args)
        {
            #region 1.2
            //Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
            ////t.IsBackground = true;
            //t.Start(15);
            //t.Join();
            //bool stopped = false;
            //Thread t = new Thread(new ThreadStart(() =>
            //    {
            //        while(!stopped)
            //        {
            //            Console.WriteLine("Running...");
            //            Thread.Sleep(1000);
            //        }
            //        Console.WriteLine("Thread is about to close");
            //    }));
            //t.Start();
            //Console.WriteLine("Press any key to exit");
            //Console.ReadKey();
            //stopped = true;
            //t.Join();
            #endregion

            #region 1.6
            //Thread t1 = new Thread(new ThreadStart(() =>
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        _field++;
            //        Console.WriteLine("thread A : {0}",_field);
            //    }
            //}));
            //t1.Start();

            //Thread t2 = new Thread(new ThreadStart(() =>
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        _field++;
            //        Console.WriteLine("thread B : {0}", _field);
            //    }
            //}));
            //t1.Join();
            //t2.Start();
            #endregion

            #region 1.7
            //ThreadPool.QueueUserWorkItem((s) =>
            //{
            //    Console.WriteLine("Working on a thread from the threadpool");
            //});
            //Console.ReadLine();
            #endregion

            #region 1.8

            #endregion
        }
    }
}