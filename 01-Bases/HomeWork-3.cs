partial class Program
{
    static void DaysOfLife()
    {
        DateTime birthDate = new DateTime(2002, 1, 4);
        TimeSpan difference = DateTime.Now - birthDate;
        Console.WriteLine($"Has vivido {difference.Days} días");


        Console.WriteLine($"FORMATO JSON: {DateTime.Now.ToString("o")}");
    }
}