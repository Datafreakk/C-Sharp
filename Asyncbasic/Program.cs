
namespace Asyncbasic
{
    class Async_one
    {
        static async Task Main(string[] args)
        {
            await AsyncOperations_TakesInteger.Takesinteger(3000);//Calling first async
        }

    }
}