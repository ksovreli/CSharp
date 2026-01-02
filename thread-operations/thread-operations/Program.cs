// 1.Thread-ის შექმნა 

Thread thread = new Thread(Method);

static void Method()
{
    for (int i = 0; i <= 10; i++)
    {
        Console.WriteLine(i);
        Thread.Sleep(500);
    }
}

thread.Start();

// 2.Thread-ის სინქრონიზაცია

int counter = 0;
object lockObject = new object();

void Counter()
{
    for (int i = 0; i < 1000; i++)
    {
        lock (lockObject)
        {
            counter++;
        }
    }
}

Thread thread1 = new Thread(Counter);
Thread thread2 = new Thread(Counter);

thread1.Start();
thread2.Start();

thread1.Join();
thread2.Join();

Console.WriteLine($"Counting completed: {counter}");