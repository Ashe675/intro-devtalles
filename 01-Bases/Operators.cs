partial class Program
{
    static void Operators()
    {
        int a = 10;
        int b = 5;

        Console.WriteLine($"Suma: {a} + {b} = {a + b}");
        Console.WriteLine($"Resta: {a} - {b} = {a - b}");
        Console.WriteLine($"Multiplicación: {a} * {b} = {a * b}");
        Console.WriteLine($"División: {a} / {b} = {a / b}");
        Console.WriteLine($"Módulo: {a} % {b} = {a % b}");

        // Operadores de comparación
        Console.WriteLine($"¿{a} es igual a {b}? {a == b}");
        Console.WriteLine($"¿{a} es diferente de {b}? {a != b}");
        Console.WriteLine($"¿{a} es mayor que {b}? {a > b}");
        Console.WriteLine($"¿{a} es menor que {b}? {a < b}");
        Console.WriteLine($"¿{a} es mayor o igual que {b}? {a >= b}");
        Console.WriteLine($"¿{a} es menor o igual que {b}? {a <= b}");

        // Operadores lógicos
        bool x = true;
        bool y = false;

        Console.WriteLine($"x AND y: {x && y}");
        Console.WriteLine($"x OR y: {x || y}");
        Console.WriteLine($"NOT x: {!x}");

        // Operador ternario
        string result = a > b ? "a es mayor que b" : "a no es mayor que b";
        Console.WriteLine(result);
    }
}