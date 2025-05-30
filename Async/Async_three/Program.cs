namespace Async_three
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            await FirstMethod();
            await SecondMethod();
        }

        public static async Task FirstMethod()
        {
            Console.WriteLine("Calling first Method");
            string message = "This is first message from first method";
            await Task.Delay(3000);
            Console.WriteLine(message);
        }

        public static async Task SecondMethod()
        {
            Console.WriteLine("Calling second Method");
            string message = "This is second message from second method";
            await Task.Delay(1000);
            Console.WriteLine(message);
        }
    }
}
