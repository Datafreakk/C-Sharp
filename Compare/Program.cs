using System;
using System.Collections.Generic;

namespace Compare;

public class CompareWrapper<T> : IComparable<CompareWrapper<T>> where T : IComparable<T>
{
    public T Value { get; }

    public CompareWrapper(T value)
    {
        Value = value;
    }

    public int CompareTo(CompareWrapper<T>? other)
    {
        if (other == null) return 1;
        return this.Value.CompareTo(other.Value);
        
    }

    public override  string ToString()
    {
        return Value?.ToString() ?? "null";
    }
}

class Program
{
    static void Main(string[] args)
    {
        var list = new List<CompareWrapper<int>>()
        {
            new CompareWrapper<int>(20),
            new CompareWrapper<int>(5),
            new CompareWrapper<int>(15),
            new CompareWrapper<int>(10)
        };
        Console.WriteLine("Before sorting:");
        foreach (var item in list)
        {
            Console.WriteLine(item); // ToString() called implicitly
        }

        // Sort the wrappers
        list.Sort();

        Console.WriteLine("\nAfter sorting:");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        // Example of comparing two wrappers
        var a = new CompareWrapper<int>(6);
        var b = new CompareWrapper<int>(10);
        Console.WriteLine($"\n compare {a} to {b}; {a.CompareTo(b)}");
    }
}