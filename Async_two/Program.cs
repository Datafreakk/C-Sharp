namespace Async_two
{

        public class Async_one
        {
            public static async Task Main(string[] args)
            {
                string fileContent = await AsyncOperations_file.ReadFileContent(3000);
                Console.WriteLine($"File content: {fileContent}");
            }
        }

        public class AsyncOperations_file
        {
            public static async Task<string> ReadFileContent(int milliseconds)
            {
                Console.WriteLine("Reading file contents...");
                string hardcodedvalue = "This is the simulated content of the file.";
                await Task.Delay(milliseconds);
                return hardcodedvalue;
            }
        }
    
}
