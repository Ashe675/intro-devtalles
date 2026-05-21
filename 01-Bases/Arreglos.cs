
partial class Program
{
    static void Arreglos()
    {
        // Declaración e inicialización de un arreglo de enteros
        int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
        // int[] numbers = { 1, 2, 3, 4, 5 };
        // int[] numbers = [ 1, 2, 3, 4, 5 ];

        // Acceso a elementos del arreglo
        Console.WriteLine($"Primer número: {numbers[0]}");
        Console.WriteLine($"Tercer número: {numbers[2]}");
        Console.WriteLine($"Último número: {numbers[^1]}"); // Usando índice desde el final

        // Modificación de un elemento del arreglo
        numbers[1] = 20;
        Console.WriteLine($"Número modificado: {numbers[1]}");

        // Recorrer el arreglo con un bucle for
        Console.WriteLine("Números en el arreglo:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        // Recorrer el arreglo con un bucle foreach
        Console.WriteLine("Números en el arreglo (foreach):");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }


        int[] firthTree = numbers[..3]; // Usando rango para obtener los primeros 3 elementos
        Console.Write("Primeros tres números: ");
        foreach (int number in firthTree)
        {
            Console.Write(number + " ");
        }

        int[] lastTwo = numbers[3..]; // Usando rango para obtener los últimos 2 elementos
        Console.Write("\nÚltimos dos números: ");
        foreach (int number in lastTwo)
        {
            Console.Write(number + " ");
        }
    }
}