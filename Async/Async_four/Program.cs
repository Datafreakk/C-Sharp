namespace Async_4
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            int initialId = 150;

            try
            {
                Task<int> idTask = GetId(initialId);
                Task<UserDetail?> getUserDetails = GetUserDetails(initialId);
                Task<List<string>?> getactivity = GetRecentActivity(initialId);

                await Task.WhenAll(idTask, getUserDetails, getactivity);

                int userIdResult = await idTask;
                UserDetail? userDetailsResult = await getUserDetails;
                List<string>? recentActivityResult = await getactivity;

                Console.WriteLine("Combined results:");
                Console.WriteLine($"UserId: {userIdResult}");

                if (userDetailsResult != null)
                {
                    Console.WriteLine($"UserName: {userDetailsResult.Name}, Age: {userDetailsResult.Age}");
                }
                else
                {
                    Console.WriteLine("User Details: Not found.");
                }

                if (recentActivityResult != null && recentActivityResult.Any())
                {
                    Console.WriteLine("Recent activity:");
                    foreach (var activity in recentActivityResult)
                    {
                        Console.WriteLine($"- {activity}");
                    }
                }
                else
                {
                    Console.WriteLine("Recent Activity: Not available.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private static async Task<int> GetId(int Id)
        {
            Console.WriteLine("Service A Starts");
            await Task.Delay(TimeSpan.FromSeconds(1));
            return Id;
        }

        private static async Task<UserDetail?> GetUserDetails(int Id)
        {
            Console.WriteLine("Service B Starts");
            await Task.Delay(TimeSpan.FromSeconds(2));

            if (Id == 100)
            {
                return new UserDetail
                {
                    Name = "praveenreddy",
                    Age = 31
                };
            }
            else if (Id == 200)
            {
                return new UserDetail
                {
                    Name = "lokesh",
                    Age = 31
                };
            }
            else
            {
                return null;
            }
        }

        private static async Task<List<string>?> GetRecentActivity(int id)
        {
            Console.WriteLine("Service C Starts");
            await Task.Delay(TimeSpan.FromSeconds(4));

            if (id > 150)
            {
                return new List<string> { "Viewed product A", "Added to cart", "Checkout initiated" };
            }
            else
            {
                return new List<string>();
            }
        }
    }

    internal class UserDetail
    {
        public string? Name { get; set; }
        public int Age { get; set; }
    }
}