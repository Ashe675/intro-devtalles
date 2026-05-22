
partial class Program
{
    static void LoopControlExamples()
    {
        // * Control de bucles: break, continue, return
        WriteLine("Ejemplo de break:");
        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                WriteLine("Se encontró el número 5, saliendo del bucle.");
                break;
            }
            WriteLine($"Iteración {i}");
        }

        WriteLine("\nEjemplo de continue:");
        for (int j = 0; j < 10; j++)
        {
            if (j % 2 == 0)
            {
                continue; // Saltar números pares
            }
            WriteLine($"Número impar: {j}");
        }

        WriteLine("\nEjemplo de return:");
        for(;;)
        {
            WriteLine("Este bucle se ejecutará indefinidamente, pero se detendrá con break.");
            break; // Salir del método, deteniendo el bucle
        }
    }
}