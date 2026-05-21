partial class Program
{
    static void DataStructures()
    {
        User pedro = new User { Name = "Pedro", Age = 30 };
        pedro.Greet();

        Point point = new Point { X = 5, Y = 10 };
        point.Display();

        CellPhone cellPhone = new CellPhone("Apple", "iPhone 13");
        Console.WriteLine($"Marca: {cellPhone.Brand}, Modelo: {cellPhone.Model}");
    }
}


class User
{
    public string? Name { get; set; }
    public int Age { get; set; }


    public void Greet()
    {
        Console.WriteLine($"Hola, mi nombre es {Name} y tengo {Age} años.");
    }

}

struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public void Display()
    {
        Console.WriteLine($"Punto en coordenadas: ({X}, {Y})");
    }
}

record CellPhone(string Brand, string Model);