
partial class Program
{
    static void AnounymousFunctions()
    {
        Func<int, int, int> add = (a, b) => a + b;
        int result = add(5, 3);
        WriteLine($"El resultado de la suma es: {result}");

        Action<string> greet = name => WriteLine($"Hola, {name}!");
        greet("Mundo");

        WriteLine($"El cuadrado de 4 es: {square(4)}");
        WriteLine($"El producto de 6 y 7 es: {multiply(6, 7)}");

        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        var evenNumbers = numbers.Where(x => x % 2 == 0);
        WriteLine("Números pares:");
        foreach (var num in evenNumbers)
        {
            WriteLine(num);
        }
    }

    static Func<int, int> square = x => x * x;

    static Func<int, int, int> multiply = delegate (int a, int b)
    {
        return a * b;
    };

}