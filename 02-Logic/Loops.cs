partial class Program
{

    static void Loops()
    {
        // * Bucles: for, while, do-while, foreach
        WriteLine("Bucle for:");
        for (int i = 0; i < 5; i++)
        {
            WriteLine($"Iteración {i}");
        }

        for(int i =10; i >=0; i-= 2)
        {
            WriteLine($"Cuenta regresiva: {i}");
        }

        WriteLine("\nBucle while:");
        int j = 0;
        while (j < 5)
        {
            WriteLine($"Iteración {j}");
            j++;
        }

        WriteLine("\nBucle do-while:");
        int k = 0;
        do
        {
            WriteLine($"Iteración {k}");
            k++;
        } while (k < 5);

        WriteLine("\nBucle foreach:");
        string[] names = { "Alice", "Bob", "Charlie" };
        string[] ages = ["25", "30", "35"];
        List<string> cities = new() { "New York", "Los Angeles", "Chicago" };

        foreach (string name in names)
        {
            WriteLine($"Hola, {name}!");
        }

        foreach (string age in ages)
        {
            WriteLine($"Edad: {age}");
        }

        foreach (string city in cities)
        {
            WriteLine($"Ciudad: {city}");
        }
    }
}