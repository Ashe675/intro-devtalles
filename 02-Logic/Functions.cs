partial class Program
{
    static void Functions()
    {
        WriteLine("¡Hola desde una función!");
        int result = Add(5, 3);
        WriteLine($"El resultado de la suma es: {result}");
    }

    static int Add(int a, int b)
    {
        return a + b;
    }
}