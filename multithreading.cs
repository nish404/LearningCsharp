using System;
using System.Threading;

/* thread = an execution path of a program we can use to perform 
 *          different tasks of our program at the same time 
 *          current thread running is a "main" thread
 *          using System.Threading
 *          => = lambda function
 */

Thread mainThread = Thread.CurrentThread;
mainThread.Name = "Main Thread";

Console.WriteLine(mainThread.Name);

Thread thread1 = new Thread(() => CountDown("Timer #1"));
Thread thread2 = new Thread(() => CountUp("Timer #2"));
thread1.Start();
thread2.Start();

Console.WriteLine(mainThread.Name + " is complete");

Console.ReadKey();

static void CountDown(String name)
{
    for (int i = 10; i >= 0; i--)
    {
        Console.WriteLine("Timer #1 : " + i +  " seconds");
        Thread.Sleep(1000);
    }
}

static void CountUp(String name)
{
    for (int i = 0; i <= 10; i++)
    {
        Console.WriteLine("Timer #2 : " + i + " seconds");
        Thread.Sleep(1000);
    }
}
