
using Microsoft.Extensions.Configuration;
using System;

namespace MoqIconfig;

class Program
{
    static void Main(string[] args)
    {
        // Build configuration
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory()) // where appsettings.json is
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        // Pass config to your class
        var dbService = new DatabaseService(configuration);

        Console.WriteLine("Connection String: " + dbService.GetConnectionString());
        Console.WriteLine("Provider: " + dbService.GetProvider());
    }
}
