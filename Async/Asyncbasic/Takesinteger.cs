using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asyncbasic
{
    public class AsyncOperations_TakesInteger
    {
        public static async Task Takesinteger(int milliseconds)
        {
            Console.WriteLine($"Starting async method with {milliseconds}");
            await Task.Delay(milliseconds);
            Console.WriteLine("Finishing  async method");
        }
    }

}
