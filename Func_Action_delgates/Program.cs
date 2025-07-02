using System;

public delegate double CalculateAreaaa(double radius);


public class ShapeCalculatorr
{
    public static double CalculateArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    //public static void CalculateAreafunc(double radius)
    // {
    //     double resultt = Math.PI * radius * radius;
    //     Console.WriteLine($"{resultt}");
    // }

    public static void ProcessArea(double val, Func<double,double> calculate) //Func Delegate return return type double 
    {
        double result = calculate(val);
        Console.WriteLine($"Output value from method func which has return  {result}");
    }
    
    public static void ProcessAreaa(double val, Action<double> calculatee) //Action delegate returns void 
    {
        calculatee(val);
        Console.WriteLine("Output from Action deleagte insacten method ");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        //ShapeCalculatorr.ProcessArea(5, ShapeCalculatorr.CalculateArea);// This is Func del call
        //ShapeCalculatorr.ProcessAreaa(5,ShapeCalculatorr.CalculateAreafunc); //This is Action del call
        ShapeCalculatorr.ProcessAreaa(3, radius =>
            Console.WriteLine
                ($"Output which Func delegate returns  {Math.PI * radius * radius}")); // This is Action del with lamba
    }
};
//an u show code for CreateUsingRabbitMq and RabbitMqBusFactoryConfigurator
//Method wants delegate → you pass lambda or matching method → method creates object → method calls delegate with object → delegate runs your config code → returns void.
