using System;
using System.Threading.Tasks;

namespace Coding_2025_practise
{
    class Async_one
    {
        static async  Task Main(string[] args)
        {
            await Takesinteger(3000);
        }

        public static async Task Takesinteger(int milliseconds)
        {
            Console.WriteLine($"Starting async method with {milliseconds}");
            await Task.Delay(milliseconds);
            Console.WriteLine("Finishing  async method");
        }
    }
}