using System;
using System.Collections.Generic;

public class CompareWrapper<T> where T : IComparable<T>
{
    public T Value { get; set; }

    public CompareWrapper(T value)
    {
        Value = value;
    }

    // Custom comparison method
    public int CompareValues(CompareWrapper<T> other)
    {
        if (other == null) return 1;
        return Value.CompareTo(other.Value);
    }

    public override string ToString() => Value?.ToString() ?? "null";
}
//
// public class Program
// {
//     public static void Main()
//     {
//         var list = new List<CompareWrapper<int>>()
//         {
//             new CompareWrapper<int>(20),
//             new CompareWrapper<int>(5),
//             new CompareWrapper<int>(15),
//             new CompareWrapper<int>(10)
//         };
//
//         Console.WriteLine("Before sorting:");
//         foreach (var item in list)
//         {
//             Console.WriteLine(item);
//         }
//
//         // Using custom comparison method in a lambda for Sort
//         list.Sort((x, y) => x.CompareValues(y));
//
//         Console.WriteLine("\nAfter sorting:");
//         foreach (var item in list)
//         {
//             Console.WriteLine(item);
//         }
//     }
// }