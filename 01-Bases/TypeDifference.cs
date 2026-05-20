partial class Program
{
    static void TypeDifference()
    {

        // En C#, los tipos de valor (como int, double, etc.) se almacenan directamente en la variable, mientras que los tipos de referencia (como string, arrays, etc.) almacenan una referencia a un objeto en memoria.
        int x = 5;
        int y = x;
        y = 15;

        Console.WriteLine($"x: {x}, y: {y}"); // x: 5, y: 15


        // Tipos de referencia, clases, objetos, arreglos, y listas, se almacenan en el heap y las variables contienen una referencia a esa ubicación de memoria. Cuando asignas una variable de tipo referencia a otra, ambas variables apuntan al mismo objeto en memoria. Por lo tanto, si modificas el objeto a través de una variable, los cambios serán visibles a través de la otra variable, ya que ambas apuntan al mismo objeto.
        Person person1 = new Person { Name = "Juan" };
        Person person2 = person1;
        person2.Name = "Pedro";
        Console.WriteLine($"person1: {person1.Name}, person2: {person2.Name}"); // person1: Pedro, person2: Pedro
    }

}

class Person
{
    public string? Name { get; set; }

}