using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Async_5;

public class Program
{
    private static readonly Random _random = new();

    public static async Task Main(string[] args)
    {
        var dataItems = Enumerable.Range(1, 20).ToList();

        Console.WriteLine("Hello, World!");
        await ProcessDataItemsAsync(dataItems);
        Console.WriteLine("All data items processed."); 
    }

    public static async Task ProcessDataItemsAsync(List<int> dataItems)
    {
        using var semaphore = new SemaphoreSlim(5);
        var tasks = new List<Task>();

        foreach (int item in dataItems)
        {
            await semaphore.WaitAsync(); 
            tasks.Add(ProcessItemAsync(item, semaphore)); 
        }

        await Task.WhenAll(tasks);
    }

    public static async Task ProcessItemAsync(int item, SemaphoreSlim semaphore)
    {
        try
        {
            Console.WriteLine($"Processing item {item}");
            int delay = _random.Next(1, 6); 
            await Task.Delay(TimeSpan.FromSeconds(delay));
            Console.WriteLine($"Processing item {item} completed");
        }
        finally
        {
            semaphore.Release();
        }
    }
}