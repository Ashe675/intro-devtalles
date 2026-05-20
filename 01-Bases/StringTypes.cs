using System.Text;

partial class Program
{
    static void ShowStringTypes()
    {
        string name = "juan";
        string message = "Hola" + " " + name;
        Console.WriteLine(message);

        string interpolatedMessage = $"Hola {name}";
        Console.WriteLine(interpolatedMessage);
        Console.WriteLine($"Length {interpolatedMessage.Length}");
        Console.WriteLine($"Mayus : {name.ToUpper()}");
        Console.WriteLine($"lower {name.ToLower()}");
        int number = 35;
        Console.WriteLine(number.ToString());

        //    REEMPLAZAR
        string original = "Hola Mundo";
        string replaced = original.Replace("Mundo", "C#");
        Console.WriteLine(replaced);

        //  Buscar
        string text = "El perro es un animal doméstico";
        bool containsPerro = text.Contains("perro");
        Console.WriteLine($"Contiene 'perro': {containsPerro}");

        // Subcadena
        string subcadena = text.Substring(3, 5);
        Console.WriteLine($"Subcadena: {subcadena}");

        string[] palabras = text.Split(' ');
        Console.WriteLine("Palabras:");
        foreach (string palabra in palabras)
        {
            Console.WriteLine(palabra);
        }
        Console.WriteLine($"PALABRAS: {palabras}");

        StringBuilder constructor = new StringBuilder();

        for (int i = 0; i < 5; i++)
        {
            constructor.Append($"Línea número {i}, ");
        }
        string resultadoFinal = constructor.ToString(); // Solo se convierte a string al final
        Console.WriteLine(resultadoFinal);
    }
}