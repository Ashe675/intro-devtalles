partial class Program
{
    static void Generics()
    {

        string[] names = { "Alice", "Bob", "Charlie" };
        int[] numbers = { 1, 2, 3 };

        // Console.WriteLine($"Longitud del arreglo de nombres: {GetStringLength(names)}");
        // Console.WriteLine($"Longitud del arreglo de números: {GetIntArrayLength(numbers)}");
        Console.WriteLine($"Longitud del arreglo de nombres: {GetArrayLength(names)}");
        Console.WriteLine($"Longitud del arreglo de números: {GetArrayLength(numbers)}");

        Box<string> stringBox = new() { Content = "Hola, mundo!" };

        stringBox.ShowContent();

    }

    static int GetIntArrayLength(int[] array)
    {
        return array.Length;
    }

    static int GetStringLength(string[] array)
    {
        return array.Length;
    }


    static int GetArrayLength<T>(T[] array)
    {
        return array.Length;
    }

}

class Box<T>
{
    public T? Content { get; set; }
    public void ShowContent()
    {
        Console.WriteLine($"El contenido de la caja es: {Content}");
    }
}