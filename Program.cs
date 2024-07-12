using System;
using System.Threading;

class Ali
{
    public static void Main()
    {
        Console.WriteLine("This program prints the output of a multi-threaded program that runs concurrently with the Main thread.");
        Console.WriteLine("-------------------------------------------------------------------------------------------------------");

        Console.WriteLine("Main Started.");
        Console.WriteLine("-------------------------------------------------------------------------------------------------------");

        Thread T1 = new Thread(Thread1);
        T1.Start();

        T1.Join();  // Main Program will wait for Thread 1 to Finish and Suspend Temporarily
        Console.WriteLine("Thread 1 Executed Successfully.");
        Console.WriteLine("-------------------------------------------------------------------------------------------------------");

        Thread T2 = new Thread(Thread2);
        T2.Start();

        T2.Join();  // Main Program will wait for Thread 2 to Finish and Suspend Temporarily
        Console.WriteLine("Thread 2 Executed Successfully.");
        Console.WriteLine("-------------------------------------------------------------------------------------------------------");

        Console.WriteLine("Main Ended.");
    }

    public static void Thread1()
    {
        Console.WriteLine("Thread 1 Function Print");
        Console.WriteLine("Thread 1 Function going to Sleep for 5s.");
        Thread.Sleep(5000);

        Console.WriteLine("-------------------------------------------------------------------------------------------------------");
        Console.WriteLine("Thread 1 Function Returning from Sleep");
    }

    public static void Thread2()
    {
        Console.WriteLine("Thread 2 Function Print");
        Console.WriteLine("Thread 2 Function going to Sleep for 5s.");
        Thread.Sleep(5000);

        Console.WriteLine("-------------------------------------------------------------------------------------------------------");
        Console.WriteLine("Thread 2 Function Returning from Sleep");
    }
}