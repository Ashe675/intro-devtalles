partial class Program
{
    static void HandleNullables()
    {
        // No nullificable
        string firstName = "Jose";
        // Nullificable
        string? lastName = null;

        Console.WriteLine($"Nombre: {firstName} ");
        Console.WriteLine($"Apellido: {lastName ?? "Apellido no proporcionado"}");

        
        string? text = null;

        Console.WriteLine($"Longitud del texto: {text?.Length ?? 0}");
    }
}