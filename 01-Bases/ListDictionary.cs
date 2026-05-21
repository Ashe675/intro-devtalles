
partial class Program
{
    static void ListDictionary()
    {
        List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
        names.Add("Diana");

        Console.WriteLine($"Total de nombres: {names.Count}");
        Console.WriteLine("Nombres en la lista:");
        foreach (string name in names)
        {
            Console.WriteLine($" - {name}");
        }

        names.Remove("Bob");
        Console.WriteLine("\nDespués de eliminar 'Bob':");
        foreach (string name in names)
        {
            Console.WriteLine($" - {name}");
        }

        // * Metodos de List
        Console.WriteLine($"\n¿La lista contiene 'Alice'? {names.Contains("Alice")}");
        Console.WriteLine($"Índice de 'Charlie': {names.IndexOf("Charlie")}");
        string? diana = names.Find(name => name.StartsWith("D")); // Encuentra el primer nombre que comienza con 'D'
        Console.WriteLine($"Primer nombre que comienza con 'D': {diana}");


        // * Diccionarios
        Dictionary<int, string> students = new Dictionary<int, string>
        {
            { 1, "Alice" },
            { 2, "Bob" },
            { 3, "Charlie" }
        };

        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.Key}, Nombre: {student.Value}");
        }
    }
}