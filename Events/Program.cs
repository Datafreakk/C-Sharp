using System;

public class Publisher
{
    public event Action<string> OnSomethingHappened;


    public void DoSomething()
    {
        Console.WriteLine("Publisher: Doing something...");
        OnSomethingHappened?.Invoke("Hello from Publisher!");
    }
}

public class Subscriber
{
    public void RespondToEvent(string message)
    {
        Console.WriteLine("Subscriber received: " + message);
    }
}

// Usage
public class Program
{
    public static void Main()
    {
        var pub = new Publisher();
        var sub = new Subscriber();

        pub.OnSomethingHappened += sub.RespondToEvent;

        pub.DoSomething();
    }
}