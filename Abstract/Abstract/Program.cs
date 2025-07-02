namespace Abstract;

public abstract class Vehicle
{
    public string  Name { get; set; }

    public Vehicle(string name)
    {
        Name = name;
    }

    public abstract void startEngine();

    public virtual void Drive()
    {
        Console.WriteLine($"Abstract Vehicle Drives");
    }
}

public class Car : Vehicle
{
    public Car(string name) : base(name)
    {
    }

    public override void startEngine()
    {
        Console.WriteLine($"Starting Engine of the car {Name}");
    }

    public override void Drive()
    {
        Console.WriteLine($"Driving from car {Name}");
    }
}

// public class Program
// {
//     public static void Main()
//     {
//         Car car = new Car("Bmw");
//         car.startEngine();
//         car.Drive();
//     }
// }

