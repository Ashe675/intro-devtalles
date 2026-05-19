
partial class Program
{
    static void ShowNumericTypes()
    {
        var integerNumber = int.MaxValue;
        double doubleNumber = 3.1416d;
        float floatingNumber = 2.61f;
        long longNumber = 300_000_000_001L;
        decimal monetaryNumber = 99.99m;
        Console.WriteLine($"Entero {integerNumber}");
        Console.WriteLine($"Double {doubleNumber}");
        Console.WriteLine($"Float {floatingNumber}");
        Console.WriteLine($"Long {longNumber}");
        Console.WriteLine($"Decimal {monetaryNumber}");
    }
}