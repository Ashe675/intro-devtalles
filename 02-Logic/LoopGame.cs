
partial class Program
{
    static void LoopGame()
    {
        int counter = 0;
        WriteLine("🎮 Pulse cualquier tecla para aumentar el contador:");
        WriteLine("Presione 'ESC' para salir.");
        while (true)
        {
            var key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Escape)
            {
                WriteLine("¡Juego terminado!");
                WriteLine($"Contador final: {counter}");
                break;
            }
            counter++;
            WriteLine($"Contador: {counter}");
        }
    }
}