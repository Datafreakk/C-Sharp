namespace Delegatewithlamba;

// Options class to be configured
public class MyServiceOptions
{
    public string Url { get; set; } = string.Empty;
    public int TimeoutSeconds { get; set; }
    public bool EnableCaching { get; set; }
    public string Name { get; set; } = string.Empty;
}

// ServiceBuilder which takes a delegate to configure MyServiceOptions
public class ServiceBuilder
{
    public void AddService(Action<MyServiceOptions> configure)
    {
        // Create instance
        MyServiceOptions optionsInstance = new MyServiceOptions();

        // Call delegate (lambda) with instance
        configure(optionsInstance);

        // For demo, print configured values
        System.Console.WriteLine($"Url: {optionsInstance.Url}");
        System.Console.WriteLine($"TimeoutSeconds: {optionsInstance.TimeoutSeconds}");
        System.Console.WriteLine($"EnableCaching: {optionsInstance.EnableCaching}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        ServiceBuilder builder = new ServiceBuilder();

        // Passing a lambda to configure options
        builder.AddService(options =>
        {
            options.Url = "https://api.myprodservice.com";
            options.TimeoutSeconds = 60;
            options.EnableCaching = true;
        });
    }
}