using Multithreading;

Thread.CurrentThread.Name = "Main thread";
Console.WriteLine(Thread.CurrentThread.Name);

// Switching threads
/*Switcher switcher = new Switcher();
switcher.Switch();*/

// Sleep thread
Writer writer = new Writer();
Thread thread1 = new Thread(writer.Write0);
Thread thread2 = new Thread(writer.Write1);
/*thread1.Start();
thread2.Start();*/

// Merges thread into current thread and waits until it is finished
// otherwise main thread would work and print Done before this methods will finish
/*thread1.Join();
thread2.Join();*/
Thread.Sleep(5000);

Console.WriteLine("Done");

for (int i = 0; i < 100; i++)
{
    ATMUnsafe atm = new ATMUnsafe();
    atm.VyberVlakny();
}

using (var mutex = new Mutex(false, "AppNameOrSomethingVerySpecific"))
{
    if (!mutex.WaitOne(5000, false))
    {
        Console.WriteLine("Aplication is already running");
    }
}

Task task = Task.Run(() =>
{
    Console.WriteLine("Writing from new thread");
    Thread.Sleep(10000);
});

Thread.Sleep(50);
Console.WriteLine(task.Status);
task.Wait();
Console.WriteLine(task.Status);
