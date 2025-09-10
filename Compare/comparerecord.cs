namespace Compare;

public record  CompareRecord(long Value ) : IComparable<CompareRecord>
{
    public static CompareRecord  Create()
    {
        return new CompareRecord(Guid.NewGuid().GetHashCode());
    }

    public int CompareTo(CompareRecord?  others)
    {
        if (others is null ) return 1;
        return Value.CompareTo(others.Value);
    }

    public override string ToString()
    {
        return $"{Value: X}";
    }
}

//usage 

internal class Program
{
    public static void Main(string[] args)
    {
        var list = new List<CompareRecord>
        {
            new CompareRecord(6),
            new CompareRecord(9),
            new CompareRecord(-1),

        };

        list.Sort();

        foreach (var item in list )
        {
            Console.WriteLine(item);
        }
    }
}