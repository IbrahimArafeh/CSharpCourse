using System;
using System.Threading;

namespace ThreadIsActiveJoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main started");

            Thread T1 = new Thread(ThreadFun1);
            T1.Start();
            if(T1.Join(1000))// don't go to second thread until finish from thread 1 
            {
                Console.WriteLine("The Thread Funtion 1 is completed 1 second");
            }
            else
            {
                Console.WriteLine("The Thread Funtion 1 is nooooooooot completed in 1 second");
            }

            if(T1.IsAlive)
            {
                Console.WriteLine("The Thread Funtion 1 is still working");
            }
            else
            {
                Console.WriteLine("The Thread Funtion 1 is finished working");
            }

            Thread T2 = new Thread(ThreadFun2);
            T2.Start();
            T2.Join();
            

            Console.WriteLine("Main Completed");
        }

        public static void ThreadFun1()
        {
            Console.WriteLine("Thread Function 1 is started");
            Thread.Sleep(5000);
            Console.WriteLine("Thread Function 1 is about to return");
        }
        public static void ThreadFun2()
        {
            Console.WriteLine("Thread Function 2 is started");
        }
        public static void ThreadFun3()
        {
            Console.WriteLine("Thread Function 3 is started");
        }
    }
}
