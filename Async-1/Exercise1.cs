using System;
using System.Threading.Tasks;

namespace Coding_2025_practise
{
    public class Exercise1
    {
        public static async Task RunAsync()
        {
            await GreetAsync("Alice");
        }

        private static async Task GreetAsync(string name)
        {
            await Task.Delay(1000); // Wait for 1 second
            Console.WriteLine($"Hello, {name}!");
        }
    }
}