using System;

namespace Delegates;

public delegate int CalcuateSum(int a, int b);

public class Delegatee // basic delegate instance and passing method as paramaters to delegate instance
{
    public static int Sumoftwonumbers(int a, int b)
    {
        int   sum = a + b;
        Console.WriteLine($"Sum is {sum}");
        return sum;
    }

    // public static void Main(string[] args)
    // {
    //     CalcuateSum delSum = new CalcuateSum(Sumoftwonumbers);
    //     delSum(1, 2);
    //
    // }
}
public delegate double CaluateAreaa(double radius);
public class ShapeCaluclator
{
    public static double CalcuateArea(double radius)
    {
        return Math.PI * radius * radius;
    }
    
    public static double CalcuateSemiArea(double radius)
    {
        return 0.5 * Math.PI * radius * radius;
    }

    public static void ProcessArea(double val, CaluateAreaa calculatormethod)
    {
        double result = calculatormethod(val);
        Console.WriteLine($"Processed area {result}");

    }

    public static void Main(string[] args)
    {
        
    ProcessArea(5.0,CalcuateArea);// Short hand for method conversion 
    ProcessArea(5.0,new CaluateAreaa(CalcuateArea)); //Explicutly passing insatcne and again passing method to delegate insatnce (method passing is imp)
    //Note : Here the magic happens , Compilers The compiler notes: "Okay, ProcessArea expects a double for its first argument and an instance of the CaluateAreaa delegate type for its second argument."
    //Core Logic// //Delagte instance , delegate  point to method and keeps a reference  , delegate passed with arguments and matches holded merhod 
    }
}