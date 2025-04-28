using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Async_5;

public class Program
{
    public async Task longrunningtask(CancellationToken cancellationToken, TimeSpan timeout)
    {
        Console.WriteLine("Long running taks started");
        using (var timeoutCts = new CancellationTokenSource())
        {
            using (var linktimeoutwithusercancellation =
                   CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, timeoutCts.Token))
            {
                timeoutCts.CancelAfter(timeout);
                try
                {
                    for (int i = 0; i < 5; i++)
                    {
                        linktimeoutwithusercancellation.Token.ThrowIfCancellationRequested();
                        await Task.Delay(1000, linktimeoutwithusercancellation.Token);
                        Console.WriteLine($"Processing{i + 1}seconds passed");
                    }
                    Console.WriteLine("Operation completed successfully.");
                }
                catch (OperationCanceledException)
                {
                    if (timeoutCts.Token.IsCancellationRequested)
                    {
                        Console.WriteLine("Operation ios cancelled by timeout");
                    }
                    else 
                    {
                        Console.WriteLine("Operation ios cancelled by user");
                    }

                    throw;

                }
            }
        }
    }

    public static async Task Run()
    {
        
    }
    
    
}